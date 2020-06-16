using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeServer
{
    public partial class ControlClient : UserControl
    {
        public FormChatServer formChat;
        public ControlClient()
        {
            InitializeComponent();
        }

        public ControlClient(string name) : this()
        {
            button1.Text = name;
            formChat = new FormChatServer(button1.Text);
            FormCommunicate.listFormChat.Add(formChat);
        }

        public void CreateFormChat()
        {
            formChat.CreateControl();
            formChat.Show();
            formChat.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formChat.Invoke(new FormUpdate(ShowForm));
        }
        delegate void FormUpdate();
        void ShowForm()
        {
            formChat.Show();
        }
        
    }
}
