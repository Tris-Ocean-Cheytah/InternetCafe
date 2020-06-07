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

namespace InternetCafeClient
{
    public partial class FormTiming : Form
    {
        //test
        private FormCommunicate communicate;
        private FormLogin loginForm;
        private string username;
        private string pass;
        Socket SckClient, SckServer;
        EndPoint ep;
        private int money;
        private int gio;
        private int phut;
        private int giay;
        private int gio2;
        private int phut2;
        private int giay2;
        byte[] data = new byte[1024];
        byte[] data1 = new byte[1024];
        EndPoint epreceiveserver = new IPEndPoint(IPAddress.Any, 0);
        EndPoint epserver = new IPEndPoint(IPAddress.Any, 999);


        public FormTiming(string username, String Pass)
        {
            InitializeComponent();
            this.username = username;
            this.pass = Pass;
            groupBox1.Text = username;
            communicate = new FormCommunicate();
            loginForm = new FormLogin();

            GetInfo(username);
            TienConLai.Text = this.money.ToString();
            TransferToTime();
            OpenConnection();
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            this.StartPosition = FormStartPosition.Manual;

            foreach (Screen scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width + 7, scrn.Bounds.Top);
                    return;
                }
            }


        }

        private void GetInfo(string username)
        {
            //tao ket noi
            SckClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //tao cong
            ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            //bat dau gui du lieu
            SckClient.SendTo(Encoding.ASCII.GetBytes("2" + username + " " + Dns.GetHostName()), ep);
            // xu ly du lieu nhan duoc
            int size = SckClient.ReceiveFrom(data, 0, 1024, SocketFlags.None, ref ep);
            string result = Encoding.ASCII.GetString(data, 0, size);
            this.money = int.Parse(result);
        }
        private void ChangeBalance(string username, int AB)
        {
            //tao ket noi
            SckClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //tao cong
            ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            //bat dau gui du lieu
            SckClient.SendTo(Encoding.ASCII.GetBytes("3" + username + " " + AB.ToString() + " " + Dns.GetHostName()), ep);
        }

        private void TimingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bạn không được phép tắt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.Cancel = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            communicate.Show();
        }
        private void foodPicBox_Click(object sender, EventArgs e)
        {
            FormOrder order;
            order = new FormOrder(this.username);
            order.Show();
        }

        private void logoutPicBox_Click(object sender, EventArgs e)
        {
            ChangeBalance(this.username, money);
            timer3.Enabled = false;
            timer2.Enabled = false;
            timer1.Enabled = false;
            SckServer.Close();
            SckClient.Close();
            this.Hide();
            loginForm.Show();
        }
        private void messPicBox_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Nhắn tin", messPicBox);
        }

        private void foodPicBox_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Gọi đồ ăn", foodPicBox);
        }

        private void logoutPicBox_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Đăng xuất", logoutPicBox);
        }

        private void keyPicBx_Click(object sender, EventArgs e)
        {
            FormSetPass formSet;
            formSet = new FormSetPass(pass, username);
            formSet.Show();
        }

        private void keyPicBx_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Đặt lại mật khẩu", keyPicBx);
        }
        public void TransferToTime()
        {
            int du;
            gio = money / 18000;
            du = money - gio * 18000;
            phut = du / (18000 / 60);
            du = du - phut * (18000 / 60);
            giay = du / (18000 / 3600);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (gio <= 0 && phut <= 0 && giay <= 0)
            {
                logoutPicBox_Click(null, null);
                MessageBox.Show("Tài khoản của bạn đã hết tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            giay--;
            if (giay < 0)
            {
                giay = 59;
                phut--;
            }
            if (phut < 0)
            {
                phut = 59;
                if (gio > 0)
                    gio--;
            }
            if (giay < 10)
            {
                GiayConLai.Text = "0" + giay;
            }
            else
                GiayConLai.Text = "" + giay;

            if (phut < 10)
            {
                PhutConLai.Text = "0" + phut;
            }
            else
                PhutConLai.Text = "" + phut;

            if (gio < 10)
            {
                GioConLai.Text = "0" + gio;
            }
            else
                GioConLai.Text = "" + gio;



            giay2++;

            if (giay2 > 59)
            {
                giay2 = 0;
                phut2++;
            }
            if (phut2 > 59)
            {
                phut2 = 0;
                gio2++;
            }

            if (giay2 < 10)
            {
                GiayDaSuDung.Text = "0" + giay2;
            }
            else
                GiayDaSuDung.Text = "" + giay2;

            if (phut2 < 10)
            {
                PhutDaSuDung.Text = "0" + phut2;
            }
            else
                PhutDaSuDung.Text = "" + phut2;

            if (gio2 < 10)
            {
                GioDaSuDung.Text = "0" + gio2;
            }
            else
                GioDaSuDung.Text = "" + gio2;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (money > 0)
            {
                money -= (18000 / 3600);
                TienConLai.Text = money.ToString();
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {

            Updatestat();
        }

        private void Updatestat()
        {
            //tao ket noi
            SckClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //tao cong
            ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            //bat dau gui du lieu
            SckClient.SendTo(Encoding.ASCII.GetBytes("7" + Dns.GetHostName() + " " + this.money), ep);
        }
        private void OpenConnection()
        {
            //tao socket
            SckServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //bind

            SckServer.Bind(epserver);
            //bat dau gui nhan du lieu
            SckServer.BeginReceiveFrom(data1, 0, 1024, SocketFlags.None, ref epreceiveserver, new AsyncCallback(receive), null);
        }

        private void receive(IAsyncResult ar)
        {
            //goi ham endreive
            try
            {
                int size = SckServer.EndReceiveFrom(ar, ref epreceiveserver);
                //Xu ly du lieu nhan duoc trong data[]
                string thongdiep = Encoding.ASCII.GetString(data1, 0, size);
                this.money += int.Parse(thongdiep);
                SckServer.BeginReceiveFrom(data1, 0, 1024, SocketFlags.None, ref epreceiveserver, new AsyncCallback(receive), null);
            }
            catch (Exception e)
            {

            }
        }
    }
}
