using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeServer.DAO
{
    class FoodDAO
    {
        public void Addfood(FoodDTO food)
        {
            try
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
                    MessageBox.Show("Thêm món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm món thất bại!\n Đã có món ăn này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<FoodDTO> Getfood()
        {
            List<FoodDTO> listfood = new List<FoodDTO>();
            String query = "SELECT * FROM Thuc_Don";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
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
                    FoodDTO add = new FoodDTO(Name, Type, Price);
                    listfood.Add(add);
                }
                connection.Close();
            }
            return listfood;
        }
    }
}
