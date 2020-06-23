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
using System.Security.Cryptography;

namespace InternetCafeClient
{
    public partial class FormLogin : Form
    {
        private string pass = "";
        private string realpass;
        private string username = "";
        public static FormTiming timingForm;
        Socket SckClient;
        EndPoint ep;
        byte[] data = new byte[1024];
        public FormLogin()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(210, Color.Black);
            this.AcceptButton = loginButton;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserDTO user = new UserDTO();
            string usernameHandler = "";
            foreach (char i in userTxtBx.Text)
            {
                if (i != ' ')
                    usernameHandler += i;
            }
            realpass = AcceptLogin(usernameHandler, pass);

            //if (GetInfo(usernameHandler) == 0)
            //    realpass = "2";
            if (realpass == "1")
            {
                if (GetInfo(usernameHandler) == 0)
                {
                    MessageBox.Show("Tài khoản không đủ tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Hide();
                    timingForm = new FormTiming(userTxtBx.Text, pass);
                    timingForm.Show();
                }
            }
            //else if (realpass == "2")
            //    MessageBox.Show("Tài khoản không đủ tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (realpass.Equals("error"))
                MessageBox.Show("Không nhận phản hồi từ server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (realpass == "0")
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (realpass == "3")
                MessageBox.Show("tài khoản đang được đăng nhập tại máy khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private string AcceptLogin(string username, string pass)
        {
            string result = "";
            try
            {
                //tao ket noi
                SckClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                //tao cong
                ep = new IPEndPoint(IPAddress.Parse("25.81.81.59"), 9999);
                //bat dau gui du lieu
                SckClient.SendTo(Encoding.ASCII.GetBytes("1" + username + " " + pass), ep);
                // xu ly du lieu nhan duoc
                int size = SckClient.ReceiveFrom(data, 0, 1024, SocketFlags.None, ref ep);
                result = Encoding.ASCII.GetString(data, 0, size);

            }
            catch (SocketException)
            {
                result = "error";
            }
            return result;
        }

        private string EncryptPassword(string pass)
        {
            byte[] temp = Encoding.ASCII.GetBytes(pass);
            byte[] hashPass = new MD5CryptoServiceProvider().ComputeHash(temp);
            string encryptedPass = "";
            foreach (var item in hashPass)
            {
                encryptedPass += item;
            }
            return encryptedPass;
        }

        private void userTxtBx_TextChanged(object sender, EventArgs e)
        {
            username = userTxtBx.Text;
        }

        private void passTxtBx_TextChanged(object sender, EventArgs e)
        {
            pass = EncryptPassword(passTxtBx.Text);
        }

        private int GetInfo(string username)
        {
            //tao ket noi
            SckClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //tao cong
            ep = new IPEndPoint(IPAddress.Parse("25.81.81.59"), 9999);
            //bat dau gui du lieu
            SckClient.SendTo(Encoding.ASCII.GetBytes("2" + username + " " + Dns.GetHostName()), ep);
            // xu ly du lieu nhan duoc
            int size = SckClient.ReceiveFrom(data, 0, 1024, SocketFlags.None, ref ep);
            string result = Encoding.ASCII.GetString(data, 0, size);
            String[] UAP = result.Split(' ');
            int money = int.Parse(UAP[0]);
            return money;
        }
    }
}


