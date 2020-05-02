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
    public partial class clientLoginForm : Form
    {
        public clientLoginForm()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(150, Color.Black);
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TimingForm timingForm = new TimingForm();
            timingForm.Show();
        }
    }
}
