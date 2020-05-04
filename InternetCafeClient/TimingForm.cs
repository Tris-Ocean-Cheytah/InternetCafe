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
    public partial class TimingForm : Form
    {
        private Communicate communicate;
        private OrderUpdateForm order;
        LoginForm loginForm;
        public TimingForm()
        {
            InitializeComponent();
            communicate = new Communicate();
            order = new OrderUpdateForm();
            loginForm = new LoginForm();
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
    }
}
