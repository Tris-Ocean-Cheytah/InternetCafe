using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetCafeServer.DAO
{
    class FoodDAO
    {
        public void Addfood(Food food)
        {
            String query = "INSERT INTO Thuc_Don VALUES(@TenMonAn,@LoaiMonAn,@DonGia)";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("TenMonAn", food.name);
                cmd.Parameters.AddWithValue("LoaiMonAn", food.type);
                cmd.Parameters.AddWithValue("DonGia", food.price);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public List<Food> Getfood()
        {
            List<Food> List = new List<Food>();
            return List;
        }
    }
}
