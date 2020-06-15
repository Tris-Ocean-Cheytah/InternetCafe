using InternetCafeServer.DAO;
using InternetCafeServer.DTO;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace InternetCafeServer
{
    public partial class FormManage : Form
    {
        Socket sckServerUdp, sckClientUdp;
        BindingSource source = new BindingSource();
        UserDAO UD = new UserDAO();
        FoodDAO FD = new FoodDAO();
        OrderDAO OD = new OrderDAO();
        FormCommunicate formCommunicate;
        byte[] data = new byte[1024];
        EndPoint dep = new IPEndPoint(IPAddress.Any, 0);
        private string Username;
        private string Password;

        public FormManage()
        {
            InitializeComponent();
            formCommunicate = new FormCommunicate();
            formCommunicate.Show();
            formCommunicate.Hide();
            Load();
        }

        new void Load()
        {
            dataGridView1.DataSource = source;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OpenConnection();
            Getalluser();
            Userbinding();
            loadlistviewfood();
        }
     
        internal void SetPassAndUser(string username, string pass)
        {
            this.Username = username;
            this.Password = pass;
        }

        private void loadlistviewfood()
        {
            listViewFood.CheckBoxes = true;
            listViewFood.Columns.Add("Tên máy", 100);
            listViewFood.Columns.Add("Tên người dùng", 130);
            listViewFood.Columns.Add("Thông tin", 500);
            listViewFood.Columns.Add("Tổng giá", 100);

        }
        private void addlistviewfood(OrderDTO order)
        {
            ListViewItem item = new ListViewItem();
            item.Text = order.name;
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = order.username });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = order.food });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = order.price });
            listViewFood.Invoke(new ControlUpdate(AddListFood), new object[] { item });
        }
        delegate void ControlUpdate(ListViewItem item);
        void AddListFood(ListViewItem item)
        {
            listViewFood.Items.Add(item);
        }

        private void Getalluser()
        {
            source.DataSource = UD.Getuser();
        }

        void Userbinding()
        {
            txtUsername.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "User_name", true, DataSourceUpdateMode.Never));
            txtMoney.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Account_balance", true, DataSourceUpdateMode.Never));
            txtPhoneNum.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Phone_number", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtID.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Citizen_identification", true, DataSourceUpdateMode.Never));
            txtDate.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Year_of_birth", true, DataSourceUpdateMode.Never));
        }

        private void OpenConnection()
        {

            //Udp
            //tao socket
            sckServerUdp = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //bind
            IPEndPoint epUdp = new IPEndPoint(IPAddress.Any, 9999);
            sckServerUdp.Bind(epUdp);
            //bat dau gui nhan du lieu
            sckServerUdp.BeginReceiveFrom(data, 0, 1024, SocketFlags.None, ref dep, new AsyncCallback(receive), null);


        }

        private void receive(IAsyncResult ar)
        {
            try
            {

                //goi ham endreive
                int size = sckServerUdp.EndReceiveFrom(ar, ref dep);
                //Xu ly du lieu nhan duoc trong data[]
                string thongdiep = Encoding.UTF8.GetString(data, 0, size);
                if (thongdiep.StartsWith("1"))
                {
                    thongdiep = thongdiep.Substring(1);
                    String[] UAP = thongdiep.Split(' ');
                    int result = UD.GetPass(UAP[0], UAP[1]);
                    sckServerUdp.SendTo(Encoding.ASCII.GetBytes(result.ToString()), dep);
                }
                else if (thongdiep.StartsWith("2"))
                {
                    thongdiep = thongdiep.Substring(1);
                    String[] UAP = thongdiep.Split(' ');
                    int result = UD.GetMoney(UAP[0]);
                    TurnOn(UAP[1], UAP[0], result);
                    sckServerUdp.SendTo(Encoding.ASCII.GetBytes(result.ToString()), dep);
                }
                else if (thongdiep.StartsWith("3"))
                {
                    thongdiep = thongdiep.Substring(1);
                    String[] UAP = thongdiep.Split(' ');
                    UD.Changebalance(UAP[0], UAP[1]);
                    TurnOff(UAP[2]);
                }
                else if (thongdiep.StartsWith("4"))
                {
                    thongdiep = thongdiep.Substring(1);
                    String[] UAP = thongdiep.Split(' ');
                    UD.Changepass(UAP[0], UAP[1]);
                }
                else if (thongdiep.StartsWith("5"))
                {
                    List<FoodDTO> list = new List<FoodDTO>();
                    list = FD.Getfood();
                    string result = ConvertToString(list);
                    sckServerUdp.SendTo(Encoding.UTF8.GetBytes(result.ToString()), dep);
                }
                else if (thongdiep.StartsWith("6"))
                {
                    thongdiep = thongdiep.Substring(1);
                    OrderDTO order = OD.Convertstringtoorder(thongdiep);
                    addlistviewfood(order);
                }
                else if (thongdiep.StartsWith("7"))
                {
                    thongdiep = thongdiep.Substring(1);
                    String[] UAP = thongdiep.Split(' ');
                    Update(UAP[0], UAP[1]);
                    sckServerUdp.SendTo(Encoding.UTF8.GetBytes("continue"), dep);
                }
                sckServerUdp.BeginReceiveFrom(data, 0, 1024, SocketFlags.None, ref dep, new AsyncCallback(receive), null);
            }
            catch (Exception)
            {

            }
        }

        private void Update(string name, string money)
        {
            TimeDTO time = TransferToTime(Convert.ToInt32(money));
            //for (int i = 0; i < listViewClient.Items.Count; i++)
            //{
            //    if (listViewClient.Items[i].SubItems[1].Text.ToString() == name)
            //    {
            //        listViewClient.Items[i].SubItems[3].Text = time.hour.ToString() + "H" + time.minute.ToString() + "M" + time.second.ToString() + "S";
            //        listViewClient.Items[i].SubItems[4].Text = money;
            //    }
            //}
            if (listViewClient.InvokeRequired)
            {
                listViewClient.Invoke((MethodInvoker)delegate ()
                {
                    for (int i = 0; i < listViewClient.Items.Count; i++)
                    {
                        if (listViewClient.Items[i].SubItems[1].Text == name)
                        {
                            listViewClient.Items[i].SubItems[4].Text = time.hour.ToString() + "h" + time.minute.ToString() + "m";
                            listViewClient.Items[i].SubItems[5].Text = money;
                        }
                    }
                });
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormAddUser form = new FormAddUser();
            form.ShowDialog();
        }

        private void stripMenuItemAddFood_Click_1(object sender, EventArgs e)
        {
            FormAddFood form = new FormAddFood();
            form.ShowDialog();
        }



        private void Finduser(string text)
        {
            source.DataSource = UD.FindUser(text);
        }

        private void Butfind_Click(object sender, EventArgs e)
        {
            Finduser(txtFind.Text);
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            UD.DelUser(txtUsername.Text);
            Getalluser();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Getalluser();
        }
        public string ConvertToString(List<FoodDTO> list)
        {
            string result = "";
            for (int i = 0; i < list.Count; i++)
            {
                result += string.Format("*" + list[i].name + "." + list[i].type + "." + list[i].price);
            }
            return result;
        }

        private void ListViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TurnOn(string name, string username, int money)
        {
            TimeDTO time = TransferToTime(money);
            //for (int i = 0; i < listViewClient.Items.Count; i++)
            //{
            //    if (listViewClient.Items[i].SubItems[0].Text == name)
            //    {
            //        listViewClient.Items[i].SubItems[1].Text = "ON";
            //        listViewClient.Items[i].SubItems[2].Text = username;
            //        listViewClient.Items[i].SubItems[3].Text = time.hour.ToString() + "H" + time.minute.ToString() + "M" + time.second.ToString() + "S";
            //        listViewClient.Items[i].SubItems[4].Text = money.ToString();
            //    }
            //}
            if (listViewClient.InvokeRequired)
            {
                listViewClient.Invoke((MethodInvoker)delegate ()
                {
                    for (int i = 0; i < listViewClient.Items.Count; i++)
                    {
                        if (listViewClient.Items[i].SubItems[0].Text == name)
                        {
                            listViewClient.Items[i].SubItems[2].Text = "ON";
                            listViewClient.Items[i].SubItems[3].Text = username;
                            listViewClient.Items[i].SubItems[4].Text = time.hour.ToString() + "h" + time.minute.ToString() + "m";
                            listViewClient.Items[i].SubItems[5].Text = money.ToString();
                        }
                    }
                });
            }
        }
        private void TurnOff(string name)
        {

            if (listViewClient.InvokeRequired)
            {
                listViewClient.Invoke((MethodInvoker)delegate ()
                {
                    for (int i = 0; i < listViewClient.Items.Count; i++)
                    {
                        if (listViewClient.Items[i].SubItems[1].Text.ToString() == name)
                        {
                            listViewClient.Items[i].SubItems[2].Text = "OFF";
                            listViewClient.Items[i].SubItems[3].Text = "";
                            listViewClient.Items[i].SubItems[4].Text = "";
                            listViewClient.Items[i].SubItems[5].Text = "";
                        }
                    }

                    //ListViewItem item = new ListViewItem();
                    //item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = name });
                    //item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "OFF" });
                    //item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
                    //item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
                    //item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });

                    //listViewClient.Items.Add(item);
                });
            }
        }
        private TimeDTO TransferToTime(int money)
        {
            TimeDTO time = new TimeDTO();
            int du;
            time.hour = money / 18000;
            du = money - time.hour * 18000;
            time.minute = du / (18000 / 60);
            du = du - time.minute * (18000 / 60);
            time.second = du / (18000 / 3600);
            return time;
        }

        private void btnCommunicate_Click(object sender, EventArgs e)
        {
            formCommunicate.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void ButChangePass_Click(object sender, EventArgs e)
        {
            FormSetPass formSet;
            formSet = new FormSetPass(this.Username,this.Password);
            formSet.Show();
        }

        private void butAddMoney_Click(object sender, EventArgs e)
        {
            int check = 0;
            for (int i = 0; i < listViewClient.Items.Count; i++)
            {
                if (listViewClient.Items[i].SubItems[3].Text == txtUsername.Text)
                {
                    check = 1;
                }
            }
            if (check == 1)
            {
                //
                //tao ket noi
                sckClientUdp = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                //tao cong
                EndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 999);
                //bat dau gui du lieu
                sckClientUdp.SendTo(Encoding.ASCII.GetBytes(txtAddMoney.Text), ep);
            }
            else
            {
                int money = UD.GetMoney(txtUsername.Text);
                money += int.Parse(txtAddMoney.Text);
                UD.Changebalance(txtUsername.Text, money.ToString());
            }
        }

    }
}
