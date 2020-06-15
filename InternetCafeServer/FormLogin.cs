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
    public partial class FormLogin : Form
    {
        UserDAO UD = new UserDAO();
        FormManage formManage;
        public FormLogin()
        {
            InitializeComponent();
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
            if(realpass=="1" && usernameHandler=="admin")
            {
                formManage = new FormManage();
                formManage.Show();
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
