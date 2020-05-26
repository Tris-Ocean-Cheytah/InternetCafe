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
    public partial class FormOrder : Form
    {
        public static List<FoodControl> foodControlsList;
        public FormOrder()
        {
            InitializeComponent();
            Food.AddFood();
            foodControlsList = new List<FoodControl>();
            foreach (Food i in Food.listFood)
            {
                if (i.type.Equals("MonChinh"))
                {
                    FoodControl fc = new FoodControl(i) { BackColor = Color.FromArgb(240, 240, 240) };
                    mainFoodPanel.Controls.Add(fc);
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
                    Console.WriteLine(i.name + i.type);
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
            else
            {
                //Đợi server
                MessageBox.Show("Đặt món hoàn tất","",MessageBoxButtons.YesNo);
            }
        }

        private void cancelPicBx_Click(object sender, EventArgs e)
        {
            for (int i = 0, j = 0; i < Food.listFood.Count - 1; i++, j++)
            {
                if (Food.listFood[i].amount != 0)
                {
                    Food.listFood[i].amount = 0;
                    foodControlsList[i].amoutUpDown.Value = 0;
                }
            }
        }

        private void MainFoodPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
