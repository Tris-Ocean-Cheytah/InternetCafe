using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InternetCafeClient
{
    class MonAn
    {
        private String MaSP;
        private String TenMonAn;
        private String LoaiMonAn;
        private int DonGia;
        public MonAn(string MaSP, String TenMonAn, String LoaiMonAn, int DonGia)
        {
            this.MaSP = MaSP;
            this.TenMonAn = TenMonAn;
            this.LoaiMonAn = LoaiMonAn;
            this.DonGia = DonGia;
        }

        public MonAn()
        {

        }

        public void ThemMonAn()
        {
            String query = "INSERT INTO Thuc_Don VALUES(@MaSP,@TenMonAn,@LoaiMonAn,@DonGia)";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("MaSP", MaSP);
                cmd.Parameters.AddWithValue("TenMonAn", TenMonAn);
                cmd.Parameters.AddWithValue("LoaiMonAn", LoaiMonAn);
                cmd.Parameters.AddWithValue("DonGia", DonGia);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void XoaMonAn(string MaSP)
        {
            String query = "DELETE FROM Thuc_Don WHERE MaSP=@MaSP";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("MaSP", MaSP);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<MonAn> LayMonAn()
        {
            String query = "SELECT * FROM Thuc_Don";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                int i = 1;
                List<MonAn> menu= new List<MonAn>();
                try{
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        menu[i].TenMonAn = (string)read["TenMonAn"];
                        menu[i].LoaiMonAn = (string)read["LoaiMonAn"];
                        menu[i].DonGia = int.Parse(read["LoaiMonAn"].ToString());
                        i++;
                    }
                    connection.Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                return menu;
            }

        }
    }
}
