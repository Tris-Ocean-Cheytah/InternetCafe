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
    public partial class FoodControl : UserControl
    {
        public Food food;
        public FoodControl()
        {
            InitializeComponent();
        }

        public FoodControl(Food food) : this()
        {
            this.food = food;
            nameLbl.Text = this.food.type;
            PricetxtBox.Text = this.food.price;
            amoutUpDown.Value = this.food.amount;
        }

        private void amoutUpDown_ValueChanged(object sender, EventArgs e)
        {
            food.amount = (int)amoutUpDown.Value;
        }

        private void NameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
