using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace InternetCafeServer
{
    class UserDTO
    {
        public string username;
        public string password;
        public string sodu;
        public string ten;
        public string namsinh;
        public string cmnd;
        public string phonenumber;

        public UserDTO()
        {

        }

        public UserDTO(string username, string password, string sodu, string ten, string namsinh, string cmnd, string phonenumber)
        {
            this.username = username;
            this.password = password;
            this.sodu = sodu;
            this.ten = ten;
            this.namsinh = namsinh;
            this.cmnd = cmnd;
            this.phonenumber = phonenumber;
        }

        //public void ThemThanhVien()
        //{
        //    String query = "INSERT INTO Thanh_Vien VALUES(@User_name,@Pass_word,@Name,@Year_of_birth,@Citizen_identification,@Phone_number,@Account_balance)";
            
        //    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand(query,connection);
        //        cmd.Parameters.AddWithValue("User_name", username);
        //        cmd.Parameters.AddWithValue("Pass_word", password);
        //        cmd.Parameters.AddWithValue("Name", ten);
        //        cmd.Parameters.AddWithValue("Year_of_birth", namsinh);
        //        cmd.Parameters.AddWithValue("Citizen_identification", cmnd);
        //        cmd.Parameters.AddWithValue("Phone_number", phonenumber);
        //        cmd.Parameters.AddWithValue("Account_balance", sodu);
        //        cmd.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //}
        //public int LayMatKhau(String username,String Pass_word)
        //{
        //    int i = 0;
        //    try {
        //        String query = "SELECT count(*) FROM Thanh_Vien WHERE User_name=@User_name AND Pass_word=@Pass_word";
        //        using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
        //        {
        //            connection.Open();
        //            SqlCommand cmd = new SqlCommand(query, connection);
        //            cmd.Parameters.AddWithValue("User_name", username);
        //            cmd.Parameters.AddWithValue("Pass_word", Pass_word);
        //            i = (int)cmd.ExecuteScalar();
        //            connection.Close();
        //        }
        //    }
        //    catch(Exception e)
        //    {
        //        i = 0;
        //    }
        //    return i;
        //    }
        //public void SuaThanhVien()
        //{
        //    String query = "UPDATE Thanh_Vien SET User_name=@User_name,Pass_word=@Pass_word,Name=@Name,Year_of_birth=@Year_of_birth,Citizen_identification=@Citizen_identification,Phone_number=@Phone_number,Account_balance=@Account_balance WHERE User_name=@User_name";

        //    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        cmd.Parameters.AddWithValue("User_name", username);
        //        cmd.Parameters.AddWithValue("Pass_word", password);
        //        cmd.Parameters.AddWithValue("Name", ten);
        //        cmd.Parameters.AddWithValue("Year_of_birth", namsinh);
        //        cmd.Parameters.AddWithValue("Citizen_identification", cmnd);
        //        cmd.Parameters.AddWithValue("Phone_number", phonenumber);
        //        cmd.Parameters.AddWithValue("Account_balance", sodu);
        //        cmd.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //}
        //public void XoaThanhVien(string username)
        //{
        //    String query = "DELETE FROM Thanh_Vien WHERE User_name=@User_name";

        //    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        cmd.Parameters.AddWithValue("User_name", username);
        //        cmd.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //}
        //public void SuaSoDu(String username,int sodu)
        //{
           
        //    String query = "UPDATE Thanh_Vien SET Account_balance=Account_balance+@Account_balance WHERE User_name=@User_name";
        //    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        cmd.Parameters.AddWithValue("User_name", username);
        //        cmd.Parameters.AddWithValue("@Account_balance", sodu);
        //        cmd.ExecuteNonQuery();
        //        connection.Close();
        //    }   
        //}
        //public void LayDuLieu()
        //{
        //    String query = "SELECT * FROM Thuc_Don WHERE username=@username";
        //    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        cmd.Parameters.AddWithValue("username", username);
        //        SqlDataReader read = cmd.ExecuteReader();
        //        username = (string)read[1];
        //        password = (string)read[2];
        //        sodu = int.Parse(read[3].ToString());
        //        ten = (string)read[4].ToString();
        //        namsinh = int.Parse(read[5].ToString());
        //        cmnd = (string)read[6];
        //        phonenumber = int.Parse(read[7].ToString());
        //        connection.Close();
        //    }

        //}
    }
}
