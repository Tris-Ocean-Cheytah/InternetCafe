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
    public partial class FormSetPass : Form
    {
        private string pass;
        private string username;
        Socket SckClient;
        EndPoint ep;

        public FormSetPass(string pass, string username)
        {
            InitializeComponent();
            this.pass = pass;
            this.username = username;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "" || txtNewPass.Text == "" || txtNewPass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string encryptPass = EncryptPassword(txtOldPass.Text);
                string encryptNewPass = EncryptPassword(txtNewPass.Text);
                string encryptConfirmPass = EncryptPassword(txtConfirmPass.Text);
                if (pass.Equals(encryptPass))
                {
                    if (encryptNewPass.Equals(encryptConfirmPass))
                    {
                        pass = encryptConfirmPass;
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetPassword();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SetPassword()
        {
            //tao ket noi
            SckClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //tao cong
            ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            //bat dau gui du lieu
            SckClient.SendTo(Encoding.ASCII.GetBytes("4" + username + " " + pass), ep);
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

        private void FormSetPass_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
