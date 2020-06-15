using System;
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
    public partial class FormChatServer : Form
    {
        public FormChatServer()
        {
            InitializeComponent();
        }


        public FormChatServer(string s) : this()
        {
            this.Text = s;
        }

        private void sendMessBtn_Click(object sender, EventArgs e)
        {
            if (txtChat.Text != "")
            {
                listBox.Items.Add("Server: " + txtChat.Text);
                string msg = Text + txtChat.Text;
                Send(msg);
                txtChat.Clear();
            }
        }

        private void FormChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        delegate void StatusUpdate();
        void AddListBox(string s)
        {
            listBox.Items.Add(s);
        }
        void ClearListBox(string s)
        {
            listBox.Items.Clear();
        }
        delegate void FormUpdate(string s);
        void SetTopMostTrue()
        {
            Show();
            TopMost = true;
        }
        void SetTopMostFalse()
        {
            TopMost = false;
        }

        public void ShowMess(string mess)
        {
            if (mess.StartsWith(Text))
            {
                this.Invoke(new StatusUpdate(SetTopMostTrue));
                this.Invoke(new StatusUpdate(SetTopMostFalse));
                string msg = "";
                for (int i = Text.Length; i < mess.Length; i++)
                {
                    msg += mess[i];
                }
                if (msg.Equals("#out#"))
                    listBox.Invoke(new FormUpdate(ClearListBox), new object[] { msg });
                else
                    listBox.Invoke(new FormUpdate(AddListBox), new object[] { Text + ": " + msg });
                Console.WriteLine(msg);
            }
        }
        public void Send(string data)
        {
            if (txtChat.Text != "")
            {
                byte[] msg = Encoding.UTF8.GetBytes(data);
                for (int i = 0; i < FormCommunicate.listClientName.Count; i++)
                {
                    if (this.Text.Equals(FormCommunicate.listClientName[i]))
                        FormCommunicate.listSckClient[i].Send(msg, 0, msg.Length, SocketFlags.None);
                }
            }
        }
    }
}
