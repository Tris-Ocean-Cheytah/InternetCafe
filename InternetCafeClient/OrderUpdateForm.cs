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
            Food.AddFood();
            List<FoodControl> foodControlsList = new List<FoodControl>();
            InitializeComponent();
            foreach (Food i in Food.listFood)
            {
                if (i.type.Equals("MonChinh"))
                {
                    FoodControl fc = new FoodControl(i) { BackColor = Color.FromArgb(240, 240, 240) };
                    mainFoodPanel1.Controls.Add(fc);
                    foodControlsList.Add(fc);
                }
                else if (i.type.Equals("DoUong"))
                {
                    FoodControl fc = new FoodControl(i) { BackColor = Color.FromArgb(240, 240, 240) };
                    drinkPanel.Controls.Add(fc);
                    foodControlsList.Add(fc);
                }
                else
                {
                    FoodControl fc = new FoodControl(i) { BackColor = Color.FromArgb(240, 240, 240) };
                    snackPanel.Controls.Add(fc);
                    foodControlsList.Add(fc);
                }
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
            bool checkEmptyCart = true;
            foreach (Food food in Food.listFood)
            {
                if (food.amount != 0)
                    checkEmptyCart = false;
            }
            if (checkEmptyCart)
            {
                MessageBox.Show("Bạn chưa đặt món ăn nào");
            }
        }

        private void cancelPicBx_Click(object sender, EventArgs e)
        {

        }

        private void MainFoodPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
