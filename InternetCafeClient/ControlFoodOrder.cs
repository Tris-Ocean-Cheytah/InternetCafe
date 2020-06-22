using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeClient
{
    public partial class ControlFoodOrder : UserControl
    {
        public FoodDTO food;
        public ControlFoodOrder()
        {
            InitializeComponent();
        }
        //.
        public ControlFoodOrder(FoodDTO food) : this()
        {
            this.food = food;
            lblName.Text = this.food.name;
            txtPrice.Text = this.food.price;
            //amoutUpDown.Value = this.food.amount;
        }

        private void amoutUpDown_ValueChanged(object sender, EventArgs e)
        {
            //food.amount = (int)amoutUpDown.Value;
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            for (int i = 0; i < FormCart.flowPnlCart.Controls.Count; i++)
            {
                if (FormCart.listFoodCart[i].lblName.Text.Equals(this.lblName.Text))
                {
                    FormCart.listFoodCart[i].numAmount.Value++;
                    isFound = true;
                }
            }
            if (!isFound)
            {
                ControlFoodCart foodCart = new ControlFoodCart(this.lblName.Text, this.txtPrice.Text);
                FormCart.listFoodCart.Add(foodCart);
                FormCart.flowPnlCart.Controls.Add(foodCart);
            }
            MessageBox.Show("Đặt món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
