﻿using System;
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

namespace InternetCafeClient
{
    public partial class FormChat : Form
    {
        public Socket sckClientTcp;
        private readonly string name = Dns.GetHostName();
        private readonly byte[] data = new byte[1024];
        private readonly string ip = Constant.IP_ADDRESS;
        public FormChat()
        {
            InitializeComponent();
            sckClientTcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint epTcp = new IPEndPoint(IPAddress.Parse(ip), 9998);
            sckClientTcp.BeginConnect(epTcp, new AsyncCallback(OnConnected), null);
        }

        private void sendMessBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtChat.Text != "")
                {
                    string msg = txtChat.Text;
                    listBox.Invoke(new UpdateForm(AddListBox), new object[] { name + ": " + txtChat.Text });
                    byte[] mess = Encoding.UTF8.GetBytes(name + msg);
                    sckClientTcp.BeginSend(mess, 0, mess.Length, SocketFlags.None, new AsyncCallback(OnDataSent), null);
                    txtChat.Clear();
                }
            }
            catch (SocketException)
            {
                sckClientTcp.Close();
            }
        }

        public void OnConnected(IAsyncResult ar)
        {
            try
            {
                sckClientTcp.EndConnect(ar);
                sckClientTcp.Send(Encoding.ASCII.GetBytes(name));
                sckClientTcp.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(OnDataReceived), null);
            }
            catch (SocketException)
            {
                sckClientTcp.Close();
            }
            catch (ObjectDisposedException)
            {
                FormLogin.timingForm.logoutPicBox_Click(null, null);
                MessageBox.Show("Không nhận phản hồi từ Server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnDataReceived(IAsyncResult ar)
        {
            try
            {
                int size = sckClientTcp.EndReceive(ar);
                string temp = Encoding.UTF8.GetString(data, 0, size);
                Console.WriteLine(temp);
                if (temp.StartsWith("#money#"))
                {
                    string msg = temp.Substring("#money#".Length);
                    string[] info = msg.Split('*');
                    Console.WriteLine(info[1]);
                    if (info[0].Equals(FormTiming.tempName))
                    {
                        FormTiming.money += int.Parse(info[1]);
                        FormTiming.TransferToTime();

                        FormTiming.TienConLai.Invoke(new UpdateForm(ChangeMoney), new object[] { FormTiming.money.ToString() });
                    }

                }
                if (temp.StartsWith(name))
                {
                    string msg = "";
                    for (int i = name.Length; i < temp.Length; i++)
                    {
                        msg += temp[i];
                    }
                    listBox.Invoke(new UpdateForm(AddListBox), new object[] { "Server: " + msg + "\r\n" });
                }
                sckClientTcp.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(OnDataReceived), null);
            }
            catch (SocketException)
            {
                sckClientTcp.Close();
            }
            catch (ObjectDisposedException)
            {
                FormLogin.timingForm.logoutPicBox_Click(null, null);
                MessageBox.Show("Không nhận phản hồi từ Server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void OnDataSent(IAsyncResult ar)
        {
            int size = sckClientTcp.EndSend(ar);
            sckClientTcp.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(OnDataReceived), null);
        }

        delegate void UpdateForm(string s);

        void ChangeMoney(string s)
        {
            FormTiming.TienConLai.Text = s;
        }
        void HideChat(string s)
        {
            Hide();
        }
        void AddListBox(string s)
        {
            listBox.Items.Add(s);
        }
        void ClearListBox(string s)
        {
            listBox.Items.Clear();
        }
        private void FormCommunicate_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void LogOut()
        {
            try
            {
                string mess = name + "#out#";
                byte[] temp = Encoding.UTF8.GetBytes(mess);
                sckClientTcp.Send(temp, 0, temp.Length, SocketFlags.None);
                listBox.Invoke(new UpdateForm(ClearListBox), new object[] { mess });
                Invoke(new UpdateForm(HideChat), new object[] { mess });
            }
            catch (Exception)
            {

            }
        }

    }
}
