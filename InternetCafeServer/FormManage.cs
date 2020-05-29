using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using InternetCafeServer.DAO;
using InternetCafeServer.DTO;
using System.Security.Cryptography;

namespace InternetCafeServer
{
    public partial class FormManage : Form
    {
        Socket SckServer;
        BindingSource source = new BindingSource();
        UserDAO UD = new UserDAO();
        FoodDAO FD = new FoodDAO();
        OrderDAO OD = new OrderDAO();
        FormCommunicate communicate;
        byte[] data = new byte[1024];
        EndPoint dep = new IPEndPoint(IPAddress.Any, 0);
        public FormManage()
        {

            InitializeComponent();
            communicate = new FormCommunicate();
            Load();
        }

        void Load()
        {
            dataGridView1.DataSource = source;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OpenConnection();
            Getalluser();
            Userbinding();
            loadlistviewfood();
        }

        private void loadlistviewfood()
        {
            listViewFood.CheckBoxes = true;
            listViewFood.Columns.Add("Tên máy",100);
            listViewFood.Columns.Add("Tên người dùng",130);
            listViewFood.Columns.Add("Thông tin",500);
            listViewFood.Columns.Add("Tổng giá",100);

        }
        private void addlistviewfood(Order order)
        {
            ListViewItem item = new ListViewItem();
            item.Text = order.name;
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = order.username });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = order.food });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = order.price });
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
            //tao socket
            SckServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //bind
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 9999);
            SckServer.Bind(ep);
            //bat dau gui nhan du lieu
            SckServer.BeginReceiveFrom(data, 0, 1024, SocketFlags.None, ref dep, new AsyncCallback(receive), null);
        }

        private void receive(IAsyncResult ar)
        {
            //goi ham endreive
            int size = SckServer.EndReceiveFrom(ar, ref dep);
            //Xu ly du lieu nhan duoc trong data[]
            string thongdiep = Encoding.ASCII.GetString(data, 0, size);
            if (thongdiep.StartsWith("1"))
            {
                thongdiep = thongdiep.Substring(1);
                String[] UAP = thongdiep.Split(' ');
                int result = UD.GetPass(UAP[0], UAP[1]);
                SckServer.SendTo(Encoding.ASCII.GetBytes(result.ToString()), dep);
            }
            else if (thongdiep.StartsWith("2"))
            {
                thongdiep = thongdiep.Substring(1);
                int result = UD.GetMoney(thongdiep);
                SckServer.SendTo(Encoding.ASCII.GetBytes(result.ToString()), dep);
            }
            else if (thongdiep.StartsWith("3"))
            {
                thongdiep = thongdiep.Substring(1);
                String[] UAP = thongdiep.Split(' ');
                UD.Changebalance(UAP[0], UAP[1]);
            }
            else if (thongdiep.StartsWith("4"))
            {
                thongdiep = thongdiep.Substring(1);
                String[] UAP = thongdiep.Split(' ');
                UD.Changepass(UAP[0], UAP[1]);
            }
            else if (thongdiep.StartsWith("5"))
            {
                List<Food> list = new List<Food>();
                list = FD.Getfood();
                string result = ConvertToString(list);
                SckServer.SendTo(Encoding.ASCII.GetBytes(result.ToString()), dep);
            }
            else if (thongdiep.StartsWith("6"))
            {
                thongdiep = thongdiep.Substring(1);
                Order order= OD.Convertstringtoorder(thongdiep);
                addlistviewfood(order);
            }
            SckServer.BeginReceiveFrom(data, 0, 1024, SocketFlags.None, ref dep, new AsyncCallback(receive), null);
        }

        private void CommunicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            communicate.Show();
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
        public string ConvertToString(List<Food> list)
        {
            string result="";
            for(int i=0;i<list.Count;i++)
            {
                result += string.Format(" "+list[i].name+"."+list[i].type+"."+list[i].price);
            }
            return result;
        }

        
    }
}
