using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetCafeServer.DAO;
namespace InternetCafeServer
{
    public partial class FormLoginServer : Form
    {
        UserDAO UD = new UserDAO();
        FormManage formManage;
        public FormLoginServer()
        {
            InitializeComponent();
            formManage = new FormManage();
            //đây là vấn đè đó :v
            // nhung ma de o day
            //ko lay dc pass de cho vao form manga
        }

        private void ButLogin_Click(object sender, EventArgs e)
        {
            string usernameHandler = "";
            foreach (char i in TxtUsername.Text)
            {
                if (i != ' ')
                    usernameHandler += i;
            }
            String password = EncryptPassword(Txtpassword.Text);
            string realpass = UD.GetPass(usernameHandler, password).ToString();
            if (realpass == "1" && usernameHandler == "admin")
            {
                formManage.SetPassAndUser(TxtUsername.Text, Txtpassword.Text);
                TxtUsername.Clear();
                Txtpassword.Clear();
                this.Hide();
                formManage.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
