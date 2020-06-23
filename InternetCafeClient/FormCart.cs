using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeClient
{
    public partial class FormCart : Form
    {
        private Socket SckClient;
        private EndPoint ep;
        private string username;
        public static List<ControlFoodCart> listFoodCart = new List<ControlFoodCart>();

        public FormCart(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void cancelPicBx_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy các món đã chọn?", "Thông báo", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                listFoodCart.Clear();
                flowPnlCart.Controls.Clear();
            }
        }

        private void acceptPicBx_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đặt món", "Thông báo", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                if (listFoodCart.Count == 0)
                {
                    MessageBox.Show("Bạn chưa chọn món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string order = "";
                    int price = 0;
                    TransferOrderToString(order, price);
                    listFoodCart.Clear();
                    flowPnlCart.Controls.Clear();
                    MessageBox.Show("Đặt món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cancelPicBx_MouseEnter(object sender, EventArgs e)
        {
            //toolTip1.Show("Hủy tất cả các món", cancelPicBx);
        }

        private void acceptPicBx_MouseEnter(object sender, EventArgs e)
        {
            //toolTip1.Show("Đặt món", cancelPicBx);
        }

        private void TransferOrderToString(string order, int price)
        {
            string name = Dns.GetHostName();
            string result = string.Format("6" + name + "*" + this.username + "*");
            foreach (ControlFoodCart item in listFoodCart)
            {
                result += String.Format(item.lblName.Text + " = " + item.numAmount.Value + "; ");
                price += (Convert.ToInt32(item.txtPrice.Text) * Convert.ToInt32(item.numAmount.Value));
            }
            result += string.Format("*" + price);
            //tao ket noi
            SckClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //tao cong
            ep = new IPEndPoint(IPAddress.Parse("25.81.81.59"), 9999);
            //bat dau gui du lieu
            SckClient.SendTo(Encoding.UTF8.GetBytes(result), ep);
        }
    }
}
