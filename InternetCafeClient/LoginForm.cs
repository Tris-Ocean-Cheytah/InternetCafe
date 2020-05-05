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
    public partial class LoginForm : Form
    {
        public string pass;
        public LoginForm()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(210, Color.Black);
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TimingForm timingForm = new TimingForm();
            timingForm.Show();
        }

        private void userTxtBx_TextChanged(object sender, EventArgs e)
        {
            string usrname = userTxtBx.Text;
            User user = new User();
            pass = user.LayMatKhau(usrname);
        }

        private void passTxtBx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
