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
using InternetCafeServer.DAO;

namespace InternetCafeServer
{
    public partial class FormManage : Form
    {
        Socket SckServer;
        DataProvider DP=new DataProvider();
        FormCommunicate communicate;
        byte[] data = new byte[1024];
        EndPoint dep = new IPEndPoint(IPAddress.Any, 0);
        public FormManage()
        {
            
            InitializeComponent();
            communicate = new FormCommunicate();
            OpenConnection();

        }

        private void OpenConnection()
        {
            //tao socket
            SckServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //bind
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 9999);
            SckServer.Bind(ep);
            //bat dau gui nhan du lieu
            SckServer.BeginReceiveFrom(data, 0, 1024, SocketFlags.None, ref dep, new AsyncCallback(receive), null);
        }

        private void receive(IAsyncResult ar)
        {
            //goi ham endreive
            int size= SckServer.EndReceiveFrom(ar, ref dep);
            //Xu ly du lieu nhan duoc trong data[]
            string thongdiep = Encoding.ASCII.GetString(data, 0, size);
            if (thongdiep.StartsWith("1"))
            {
                thongdiep = thongdiep.Substring(1);
                String[] UAP = thongdiep.Split(' ');
                int result = DP.GetPass(UAP[0], UAP[1]);
                SckServer.SendTo(Encoding.ASCII.GetBytes(result.ToString()), dep);
            }
            else if(thongdiep.StartsWith("2"))
            {
                thongdiep = thongdiep.Substring(1);
                int result = DP.GetMoney(thongdiep);
                SckServer.SendTo(Encoding.ASCII.GetBytes(result.ToString()), dep);
            }
            else if (thongdiep.StartsWith("3"))
            {
                thongdiep = thongdiep.Substring(1);
                String[] UAP = thongdiep.Split(' ');
                DP.Changebalance(UAP[0], UAP[1]);
            }
            SckServer.BeginReceiveFrom(data, 0, 1024, SocketFlags.None, ref dep, new AsyncCallback(receive), null);
        }

        private void CommunicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            communicate.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormAddUser form = new FormAddUser();
            form.ShowDialog();
        }

        private void stripMenuItemAddFood_Click_1(object sender, EventArgs e)
        {
            FormAddFood form = new FormAddFood();
            form.ShowDialog();  
        }
    }
}
