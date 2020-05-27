using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetCafeServer.DAO;
namespace InternetCafeServer
{
    public partial class FormAddFood : Form
    {
        FoodDAO f = new FoodDAO();
        public FormAddFood()
        {
            InitializeComponent();
        }

        private void BtnAddFood_Click(object sender, EventArgs e)
        {
            f.Addfood(new Food(txtFood.Text, txtType.Text, txtPrice.Text));
        }
    }
}
