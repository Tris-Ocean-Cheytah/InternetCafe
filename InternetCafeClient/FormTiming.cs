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
        private FormOrder order;
        private FormLogin loginForm;
        private FormSetPass formSet;
        private string username;
        Socket SckClient;
        EndPoint ep;
        private int time;
        private int money;
        private int gio;
        private int phut;
        private int giay;
        private int gio2;
        private int phut2;
        private int giay2;
        byte[] data = new byte[1024];
        public FormTiming(string username)
        {
            this.username = username;
            InitializeComponent();
            communicate = new FormCommunicate();
            order = new FormOrder();
            loginForm = new FormLogin();
            formSet = new FormSetPass();
            GetInfo(username);
            TienConLai.Text = this.money.ToString();
            TransferToTime();
            timer1.Enabled = true;
            timer2.Enabled = true;
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
            SckClient.SendTo(Encoding.ASCII.GetBytes("2" + username), ep);
            // xu ly du lieu nhan duoc
            int size = SckClient.ReceiveFrom(data, 0, 1024, SocketFlags.None, ref ep);
            string result = Encoding.ASCII.GetString(data, 0, size);
            this.money = int.Parse(result);
        }
        private void ChangeBalance(string username,int AB)
        {
            //tao ket noi
            SckClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //tao cong
            ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            //bat dau gui du lieu
            SckClient.SendTo(Encoding.ASCII.GetBytes("3" + username+" "+AB.ToString()), ep);
        }

        private void TimingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bạn không được phép tắt", "Thông báo");
            e.Cancel = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            communicate.Show();
        }
        private void foodPicBox_Click(object sender, EventArgs e)
        {
            order.Show();
        }

        private void logoutPicBox_Click(object sender, EventArgs e)
        {
            ChangeBalance(this.username, money);
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
            phut = du / (18000/60);
            du = du-phut*(18000/60);
            giay = du / (18000 / 3600);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            giay--;
            if (giay < 1)
            {
                giay = 59;
                phut--;
            }
            if (phut < 1)
            {
                phut = 59;
                gio--;
            }
            if (gio == 0 && phut==0 &&giay==0)
            {
                logoutPicBox_Click(null,null);
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
                gio++;
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
            money = money - 25;
            TienConLai.Text = money.ToString();
        }
    }
}
