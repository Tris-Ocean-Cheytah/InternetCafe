using InternetCafeServer.DAO;
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


namespace InternetCafeServer
{
    public partial class FormAddUser : Form
    {
        UserDAO ur = new UserDAO();
        public FormAddUser()
        {
            InitializeComponent();
            
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

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            
            string pass = EncryptPassword(txtPass.Text);
            ur.AddUser(new UserDTO(txtUsername.Text, pass,  txtMoney.Text, txtName.Text, txtDate.Text, txtID.Text,txtPhoneNum.Text));
               
            
        }
    }
}
