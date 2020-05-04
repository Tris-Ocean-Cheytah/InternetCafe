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
    public partial class OrderUpdateForm : Form
    {
        public OrderUpdateForm()
        {
            InitializeComponent();
            Food.AddFood();
            foreach (Food i in Food.listFood)
            {
                if (i.type.Equals("Mon Chinh"))
                    mainFoodPanel1.Controls.Add(new FoodControl(i) { BackColor = Color.FromArgb(240, 240, 240) });
                else if (i.type.Equals("Do uong"))
                    drinkPanel.Controls.Add(new FoodControl(i) { BackColor = Color.FromArgb(240, 240, 240) });
                else
                    snackPanel.Controls.Add(new FoodControl(i) { BackColor = Color.FromArgb(240, 240, 240) });
            }
        }

        private void acceptPicBx_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Đặt các món đã chọn", acceptPicBx);
        }

        private void cancelPicBx_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Hủy các món đã chọn", cancelPicBx);
        }

        private void acceptPicBx_Click(object sender, EventArgs e)
        {

        }

        private void cancelPicBx_Click(object sender, EventArgs e)
        {

        }

        private void OrderUpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
