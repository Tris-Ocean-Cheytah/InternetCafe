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
            if (txtFood.Text.Equals("") || txtType.Text.Equals("") || txtPrice.Text.Equals(""))
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (txtType.Text.Equals("MonAn"))
                    f.Addfood(new FoodDTO(txtFood.Text, txtType.Text, txtPrice.Text));
                else if (txtType.Text.Equals("DoUong"))
                    f.Addfood(new FoodDTO(txtFood.Text, txtType.Text, txtPrice.Text));
                else if (txtType.Text.Equals("AnNhe"))
                    f.Addfood(new FoodDTO(txtFood.Text, txtType.Text, txtPrice.Text));
                else
                    MessageBox.Show("Loại đồ ăn k hợp lệ\nGiá trị hợp lệ: MonChinh, DoUong, AnNhe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
