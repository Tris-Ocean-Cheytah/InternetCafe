using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace InternetCafeClient
{
    public class Food
    {
        public static List<Food> listFood = new List<Food>();
        public string name;
        public string price;
        public string type;
        public int amount;
        public Food()
        {
            this.amount = 0;
        }

        public Food(string type) : this()
        {
            this.type = type;
        }
        public Food(string name, string type, string price) : this()
        {
            this.type = type;
            this.name = name;
            this.price = price;
        }
        static public void AddFood()
        {
            GetFoodFromDatabase();
        }

        static public void GetFoodFromDatabase()
        {
            String query = "SELECT * FROM Thuc_Don";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        //int count = 0;
                        string Name = (string)read["TenMonAn"];
                        string Type = (string)read["LoaiMonAn"];
                        string Price = (string)read["DonGia"];
                        Food add = new Food(Name, Type, Price);
                        listFood.Add(add);
                        //tao lấy rồi add vào list food
                        //while(true)
                        //{
                        //    if (listFood[count].type.Equals("MonChinh"))
                        //    {
                        //        listFood[count].name = Name;
                        //        listFood[count].price = Price;
                        //        break;
                        //    }
                        //    else if (listFood[count].type.Equals("DoUong"))
                        //    {
                        //        listFood[count].name = Name;
                        //        listFood[count].price = Price;
                        //        break;
                        //    }
                        //    else if (listFood[count].type.Equals("AnNhe"))
                        //    {
                        //        listFood[count].name = Name;
                        //        listFood[count].price = Price;
                        //        break;
                        //    }
                        //    count++;
                        //}
                    }
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }

        }
    }
}
