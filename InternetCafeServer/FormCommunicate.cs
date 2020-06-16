using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeServer
{
    public partial class FormCommunicate : Form
    {
        public Socket sckServerTcp;
        public static List<FormChatServer> listFormChat = new List<FormChatServer>();
        public static List<Socket> listSckClient = new List<Socket>();
        public static List<string> listClientName = new List<string>();
        private List<ControlClient> listControl = new List<ControlClient>();
        private byte[] data = new byte[1024];
        public FormCommunicate()
        {
            InitializeComponent();
            try
            {
                sckServerTcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //đây
                IPEndPoint epTcp = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9998);
                sckServerTcp.Bind(epTcp);
                sckServerTcp.Listen(10);
                sckServerTcp.BeginAccept(new AsyncCallback(OnConnected), sckServerTcp);
            }
            catch (SocketException)
            {
                sckServerTcp.Close();
            }
            for (int i = 0; i < 20; i++)
            {
                string name = "MAY" + (i + 1);
                ControlClient control = new ControlClient(name);
                control.Enabled = false;
                flowLayoutPanel1.Controls.Add(control);
                listControl.Add(control);
                listClientName.Add(name);
                listSckClient.Add(new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp));

            }
        }

        public void OnConnected(IAsyncResult ar)
        {
            try
            {
                Socket clientTest = sckServerTcp.EndAccept(ar);

                Console.WriteLine(((IPEndPoint)clientTest.RemoteEndPoint).Address.ToString());

                int n = clientTest.Receive(data, 0, data.Length, SocketFlags.None);
                string msg = Encoding.ASCII.GetString(data, 0, n);
                Console.WriteLine(msg);
                for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                {
                    if (msg.StartsWith(listClientName[i]))
                    {
                        flowLayoutPanel1.Invoke(new FormUpdate(ChangeStatusEnable), new object[] { i });
                        listControl[i].Invoke(new FormUpdate(CreateForm), new object[] { i });
                        listSckClient[i] = clientTest;
                    }
                }
                try
                {
                    sckServerTcp.BeginAccept(new AsyncCallback(OnConnected), sckServerTcp);
                    clientTest.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(OnDataReceived), clientTest);
                }
                catch (SocketException)
                {
                    CloseClient(clientTest);
                }
            }
            catch (ObjectDisposedException)
            {

            }

        }
        delegate void FormUpdate(int i);
        void ChangeStatusEnable(int i)
        {
            flowLayoutPanel1.Controls[i].Enabled = true;
        }
        void ChangeStatusDisable(int i)
        {
            flowLayoutPanel1.Controls[i].Enabled = false;
        }
        void HideChat(int i)
        {
            listControl[i].formChat.Hide();
        }
        void CreateForm(int i)
        {
            listControl[i].CreateFormChat();
        }


        private void OnDataReceived(IAsyncResult ar)
        {
            Socket client = (Socket)ar.AsyncState;
            try
            {
                int size = client.EndReceive(ar);
                if (size == 0)
                {
                    CloseClient(client);
                }
                else
                {
                    string msg = Encoding.UTF8.GetString(data, 0, size);
                    for (int i = 0; i < listFormChat.Count; i++)
                    {
                        if (msg.StartsWith(listFormChat[i].Text))
                        {
                            listFormChat[i].ShowMess(msg);
                            string split = msg.Substring(listFormChat[i].Text.Length, msg.Length - listFormChat[i].Text.Length);
                            if (split.Equals("#out#"))
                            {
                                flowLayoutPanel1.Invoke(new FormUpdate(ChangeStatusDisable), new object[] { i });
                                listControl[i].formChat.Invoke(new FormUpdate(HideChat), new object[] { i });
                            }
                        }
                    }
                    client.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(OnDataReceived), client);
                }
            }
            catch (SocketException)
            {
                CloseClient(client);
            }
        }
        public void CloseClient(Socket client)
        {
            client.Close();
        }

        private void FormCommunicate_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
