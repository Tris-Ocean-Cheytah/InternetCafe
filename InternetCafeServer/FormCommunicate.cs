﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeServer
{
    public partial class FormCommunicate : Form
    {
        public byte[] data = new byte[1024];
        public static List<FormChatServer> listClientName = new List<FormChatServer>();
        static public List<Socket> listSckClient = new List<Socket>();
        List<ControlClient> listControl = new List<ControlClient>();
        public static TextBox txtMsgServer = new TextBox();
        public FormCommunicate()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++)
            {
                string name = "MAY" + (i + 1);
                ControlClient control = new ControlClient(name);
                control.Enabled = false;
                flowLayoutPanel1.Controls.Add(control);
                listControl.Add(control);
            }
        }

        public void OnConnected(IAsyncResult ar)
        {
            Socket clientTest = FormManage.sckServerTcp.EndAccept(ar);
            listSckClient.Add(clientTest);
            int n = clientTest.Receive(data, 0, data.Length, SocketFlags.None);
            string msg = Encoding.ASCII.GetString(data, 0, n);
            Console.WriteLine(msg);
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                if (msg.StartsWith(listClientName[i].Text))
                {
                    flowLayoutPanel1.Invoke(new FormUpdate(ChangeStatusEnable), new object[] { i });
                }
            }
            try
            {
                FormManage.sckServerTcp.BeginAccept(new AsyncCallback(OnConnected), FormManage.sckServerTcp);
                clientTest.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(OnDataReceived), clientTest);
            }
            catch (SocketException)
            {
                CloseClient(clientTest);
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
                    for (int i = 0; i < listClientName.Count; i++)
                    {
                        if (msg.StartsWith(listClientName[i].Text))
                        {
                            listClientName[i].ShowMess(msg);
                            string split = msg.Substring(listClientName[i].Text.Length, msg.Length - listClientName[i].Text.Length);
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
