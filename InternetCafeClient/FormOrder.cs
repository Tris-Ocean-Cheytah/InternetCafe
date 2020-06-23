using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetCafeClient.DAO;
using System.Net;
using System.Net.Sockets;

namespace InternetCafeClient
{
    public partial class FormOrder : Form
    {
        private FoodDAO FP = new FoodDAO();
        private string username;
        private FormCart formCart;
        private List<FoodDTO> listfood = new List<FoodDTO>();

        public FormOrder(string username)
        {
            InitializeComponent();
            this.username = username;
            formCart = new FormCart(username);
            string result = FP.GetFoodFromServer();
            listfood = FP.ConvertToListFood(result);
            foreach (FoodDTO i in listfood)
            {
                if (i.type.Equals("MonChinh"))
                {
                    ControlFoodOrder fc = new ControlFoodOrder(i) { BackColor = Color.FromArgb(240, 240, 240) };
                    mainFoodPanel.Controls.Add(fc);

                }
                else if (i.type.Equals("DoUong"))
                {
                    ControlFoodOrder fc = new ControlFoodOrder(i) { BackColor = Color.FromArgb(240, 240, 240) };
                    drinkPanel.Controls.Add(fc);
                }
                else
                {
                    ControlFoodOrder fc = new ControlFoodOrder(i) { BackColor = Color.FromArgb(240, 240, 240) };
                    snackPanel.Controls.Add(fc);
                }
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        { 
            formCart.ShowDialog();
        }

        private void btnCart_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Xem giỏ hàng", btnCart);
        }

        private void FormOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
