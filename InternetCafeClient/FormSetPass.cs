using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace InternetCafeClient
{
    public partial class FormSetPass : Form
    {
        private string pass;
        private string username;
        Socket SckClient;
        EndPoint ep;

        public FormSetPass(string pass,string username)
        {
            InitializeComponent();
            this.pass = pass;
            this.username = username;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(pass==txtOldPass.Text)
            {
                if(txtNewPass.Text==txtConfirmPass.Text)
                {
                    this.pass = txtConfirmPass.Text;
                    MessageBox.Show("Doi mat khau thanh cong!");
                    SetPassword();
                }
                else
                {
                    MessageBox.Show("Nhap lai mat khau moi khong dung!");
                }
            }
            else
            {
                MessageBox.Show("Nhap sai mat khau cu!");
            }
        }

        private void SetPassword()
        {
            //tao ket noi
            SckClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //tao cong
            ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            //bat dau gui du lieu
            SckClient.SendTo(Encoding.ASCII.GetBytes("4" + username+" "+pass), ep);
        }
    }
}
