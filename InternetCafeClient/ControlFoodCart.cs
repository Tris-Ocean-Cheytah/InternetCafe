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
    public partial class ControlFoodCart : UserControl
    {
        public ControlFoodCart()
        {
            InitializeComponent();
        }

        public ControlFoodCart(string name, string price) : this()
        {
            lblName.Text = name;
            txtPrice.Text = price;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn hủy món?", "Thông báo", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                FormCart.listFoodCart.Remove(this);
                FormCart.flowPnlCart.Controls.Remove(this);
            }
        }
    }
}
