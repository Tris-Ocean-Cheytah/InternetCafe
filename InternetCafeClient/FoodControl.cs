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
        public FoodControl()
        {
            InitializeComponent();
        }

        public FoodControl(Food food) : this()
        {
            nameLbl.Text = food.name;
            PricetxtBox.Text = food.price;
            amoutUpDown.Value = food.amount;
        }
    }
}
