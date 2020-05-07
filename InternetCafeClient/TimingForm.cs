using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InternetCafeClient
{
    public partial class TimingForm : Form
    {
        private Communicate communicate;
        private OrderUpdateForm order;
        LoginForm loginForm;
        private string username;
        private int money;
        private int time;
        private int gio;
        private int phut;
        private int giay;
        private int gio2 = 0;
        private int phut2 = 0;
        private int giay2 = 0;
        public TimingForm(String username)
        {
            InitializeComponent();
            this.username = username;
            GetMoneyFromDatabase();
            TransferToTime();
            timer1.Enabled = true;
            timer2.Enabled = true;
            MoneyRemaining.Text = "" + money;
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

        private void PerHourTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            giay--;
            if (giay<1)
            {
                giay = 59;
                phut--;
            }
            if(phut<1)
            {
                phut = 59;
                gio--;
            }
            if(gio==0)
            {
                this.Hide();
                timer1.Enabled = false;
                timer2.Enabled = false;

                loginForm.Show();
            }
            if (giay < 10)
            {
                GiayConLai.Text = "0" + giay;
            }
            else
                GiayConLai.Text =""+giay;

            if (phut < 10)
            {
                PhutConLai.Text = "0" + phut;
            }
            else
                PhutConLai.Text =""+ phut;

            if (gio < 10)
            {
                GioConLai.Text = "0" + gio;
            }
            else
                GioConLai.Text =""+ gio;

            

            giay2++;

            if (giay2 >59 )
            {
                giay2 = 0;
                phut2++;
            }
            if (phut2 > 59)
            {
                phut2 = 0;
                gio++;
            }
            
            if (giay2 < 10)
            {
                GiayDaSuDung.Text = "0" + giay2;
            }
            else
                GiayDaSuDung.Text = "" + giay2;

            if (phut2 < 10)
            {
                PhutDaSuDung.Text = "0" + phut2;
            }
            else
                PhutDaSuDung.Text = "" + phut2;

            if (gio2 < 10)
            {
                GioDaSuDung.Text = "0" + gio2;
            }
            else
                GioDaSuDung.Text = "" + gio2;
        }
        public void GetMoneyFromDatabase()
        {
            String query = "SELECT Account_balance FROM Thanh_Vien where @User_Name=User_name";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("User_name", username);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        this.money = Convert.ToInt32(read["Account_balance"]);
                    }
                    connection.Close();


                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }

        }
        public void TransferToTime()
        {
            int du;
            time = (money / 18000) * 3600;
            gio = time / 3600;
            du = time % 3600;
            time = time / 3600;
            time = time + du;
            phut = time / 60;
            giay = time % 60;
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            money = money - 25;
            MoneyRemaining.Text = money.ToString();
        }

        private void TimeRemaining_Click(object sender, EventArgs e)
        {

        }
    }
}
