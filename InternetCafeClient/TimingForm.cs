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
        public TimingForm()
        {
            InitializeComponent();
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
            Communicate communicate = new Communicate();
            communicate.Show();
            
        }
        private void foodPicBox_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void logoutPicBox_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Nhắn tin", messPicBox);
        }

        private void foodPicBox_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Gọi đồ ăn", foodPicBox);
        }

        private void pictureBox2_MouseEnter_1(object sender, EventArgs e)
        {
            toolTip1.Show("Đăng xuất", logoutPicBox);
        }
    }
}
