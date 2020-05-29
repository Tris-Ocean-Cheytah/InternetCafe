﻿using System;
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
            List<Food> listfood = new List<Food>();
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
                    Food add = new Food(Name, Type, Price);
                    listfood.Add(add);
                }
                connection.Close();
            }
            return listfood;
        }
    }
}