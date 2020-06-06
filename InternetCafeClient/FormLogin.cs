using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeClient
{
    public partial class FormLogin : Form
    {
        private string pass="";
        private int realpass;
        private string username = "";
        FormTiming timingForm;
        public FormLogin()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(210, Color.Black);
            this.AcceptButton = loginButton;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            realpass = user.LayMatKhau(username,pass);
            if (realpass == 1)
            {
                this.Hide();
                timingForm = new FormTiming();
                timingForm.Show();
            }
            else
                MessageBox.Show("wrong username or password");
        }

        private void userTxtBx_TextChanged(object sender, EventArgs e)
        {
            username = userTxtBx.Text;
        }

        private void passTxtBx_TextChanged(object sender, EventArgs e)
        {
            pass = passTxtBx.Text;
        }
    }
}
// khác nhau ở chỗ lồn nào ? :))) ddc ko?
// m thử test lại xem chạy đi ???
//đang ở branch master
// t vừa merge vào rồi
// thử push r

