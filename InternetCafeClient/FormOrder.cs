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
        Socket SckClient;
        EndPoint ep;
        public static List<FoodControl> foodControlsList;
        List<FoodDTO> listfood = new List<FoodDTO>();
        FoodDAO FP = new FoodDAO();
        private string username;
        private readonly string ip = Constant.IP_ADDRESS;
        public FormOrder(string username)
        {
            this.username = username;
            InitializeComponent();
            string result = FP.GetFoodFromServer();
            listfood = FP.ConvertToListFood(result);
            foodControlsList = new List<FoodControl>();
            foreach (FoodDTO i in listfood)
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
            DialogResult dr = MessageBox.Show("Bạn đã chắc chắn muốn đặt các món đã chọn không ?", "Thông báo", MessageBoxButtons.YesNo,
        MessageBoxIcon.Information);
            if(dr == DialogResult.Yes)
            {
                bool checkEmptyCart = true;
                string order = "";
                int price = 0;
                foreach (FoodDTO food in listfood)
                {
                    if (food.amount != 0)
                        checkEmptyCart = false;
                }
                if (checkEmptyCart)
                {
                    MessageBox.Show("Bạn chưa đặt món ăn nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string noti = notification();
                    transferordertostring(order, price);
                    MessageBox.Show(noti, "Đặt món thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = 0, j = 0; i < listfood.Count; i++, j++)
                    {
                        if (listfood[i].amount != 0)
                        {
                            listfood[i].amount = 0;
                            foodControlsList[i].amoutUpDown.Value = 0;
                        }
                    }
                }
            }
            
        }

        private string notification()
        {
            string noti = "Bạn đã đặt \n";
            foreach (FoodDTO food in listfood)
            {
                if (food.amount != 0)
                {
                    noti += string.Format(food.amount + " " + food.name + "\n");
                }
            }
            return noti;
        }

        private void transferordertostring(string order, int price)
        {
            string name = Dns.GetHostName();
            string result = string.Format("6" + name + "*" + this.username + "*");
            foreach (FoodDTO food in listfood)
            {
                if (food.amount != 0)
                {
                    result += string.Format(food.name + "=" + food.amount + ";");
                    price += (Convert.ToInt32(food.price) * food.amount);
                }
            }
            result += string.Format("*" + price);
            //tao ket noi
            SckClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //tao cong
            ep = new IPEndPoint(IPAddress.Parse(ip), 9999);
            //bat dau gui du lieu
            SckClient.SendTo(Encoding.UTF8.GetBytes(result), ep);
        }
        private void cancelPicBx_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy tất cả các món đã chọn không ?", "Thông báo", MessageBoxButtons.YesNo,
        MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                for (int i = 0, j = 0; i < listfood.Count; i++, j++)
                {
                    if (listfood[i].amount != 0)
                    {
                        listfood[i].amount = 0;
                        foodControlsList[i].amoutUpDown.Value = 0;
                    }
                }
            }
        }

        private void MainFoodPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormOrder_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
