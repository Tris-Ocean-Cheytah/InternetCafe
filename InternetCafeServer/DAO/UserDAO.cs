using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetCafeServer;
namespace InternetCafeServer.DAO
{
    class UserDAO
    {
        public void AddUser(UserDTO user)
        {
            try
            {
                String query = "INSERT INTO Thanh_Vien VALUES(@User_name,@Pass_word,@Name,@Year_of_birth,@Citizen_identification,@Phone_number,@Account_balance)";

                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("User_name", user.username);
                    cmd.Parameters.AddWithValue("Pass_word", user.password);
                    cmd.Parameters.AddWithValue("Name", user.ten);
                    cmd.Parameters.AddWithValue("Year_of_birth", user.namsinh);
                    cmd.Parameters.AddWithValue("Citizen_identification", user.cmnd);
                    cmd.Parameters.AddWithValue("Phone_number", user.phonenumber);
                    cmd.Parameters.AddWithValue("Account_balance", user.sodu);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Thêm người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Tên người dùng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        public int GetPass(string username, string password)
        {
            int i = 0;
            try
            {
                string query = "SELECT count(*) FROM Thanh_Vien WHERE User_name=@User_name AND Pass_word=@Pass_word";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("User_name", username);
                    cmd.Parameters.AddWithValue("Pass_word", password);
                    i = (int)cmd.ExecuteScalar();
                    connection.Close();
                }
            }
            catch (Exception)
            {
                i = 0;
            }
            return i;
        }
        public void ChangeUser(string username, string password, string ten, string namsinh, string phonenumber, string cmnd, string sodu)
        {
            String query = "UPDATE Thanh_Vien SET User_name=@User_name,Pass_word=@Pass_word,Name=@Name,Year_of_birth=@Year_of_birth,Citizen_identification=@Citizen_identification,Phone_number=@Phone_number,Account_balance=@Account_balance WHERE User_name=@User_name";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("User_name", username);
                cmd.Parameters.AddWithValue("Pass_word", password);
                cmd.Parameters.AddWithValue("Name", ten);
                cmd.Parameters.AddWithValue("Year_of_birth", namsinh);
                cmd.Parameters.AddWithValue("Citizen_identification", cmnd);
                cmd.Parameters.AddWithValue("Phone_number", phonenumber);
                cmd.Parameters.AddWithValue("Account_balance", sodu);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void DelUser(string username)
        {
            try
            {
                String query = "DELETE FROM Thanh_Vien WHERE User_name=@User_name";

                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("User_name", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal  DataTable Getuser()
        {
            String query = string.Format("SELECT * FROM Thanh_vien ");
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        internal DataTable FindUser(string text)
        {
            String query = string.Format("SELECT * FROM Thanh_vien Where User_name like N'%{0}%'", text);
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public void Changebalance(String username, string sodu)
        {

            String query = "UPDATE Thanh_Vien SET Account_balance=@Account_balance WHERE User_name=@User_name";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("User_name", username);
                cmd.Parameters.AddWithValue("Account_balance", sodu);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Changepass(String username, string pass)
        {

            String query = "UPDATE Thanh_Vien SET Pass_word=@Pass_word WHERE User_name=@User_name";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("User_name", username);
                cmd.Parameters.AddWithValue("Pass_word", pass);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public int GetMoney(string username)
        {
            String query = "SELECT Account_balance FROM Thanh_vien Where User_name=@User_name";
            int money = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("User_name", username);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    money = Convert.ToInt32(read["Account_balance"]);
                }
                connection.Close();
            }
            return money;
        }
    }
}
