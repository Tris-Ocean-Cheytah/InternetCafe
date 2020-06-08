using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeServer
{
    public partial class FormChatServer : Form
    {
        static public TextBox textChatTempServer = new TextBox();
        public FormChatServer()
        {
            InitializeComponent();
            textChatTempServer.Location = new Point(40, 40);
            textChatTempServer.Visible = false;
            textChatTempServer.TextChanged += TextChatTempServer_TextChanged;
        }

        private void TextChatTempServer_TextChanged(object sender, EventArgs e)
        {
            this.Invoke(new StatusUpdate(SetTopMostTrue));
            this.Invoke(new StatusUpdate(SetTopMostFalse));
            if (textChatTempServer.Text.StartsWith(Text))
            {
                string msg = "";
                for (int i = Text.Length; i < textChatTempServer.Text.Length; i++)
                {
                    msg += textChatTempServer.Text[i];
                }
                listBox.Invoke(new FormUpdate(AddListBox), new object[] { Text + ": " + msg });
            }
        }

        public FormChatServer(string s):this()
        {
            this.Text = s;
        }

        private void sendMessBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Add("Server: " + txtChat.Text);
            FormCommunicate.txtMsgServer.Text = Text + txtChat.Text;
            txtChat.Clear();
        }

        private void FormChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        delegate void FormUpdate(string s);
        delegate void StatusUpdate();
        void AddListBox(string s)
        {
            listBox.Items.Add(s);
        }
        void SetTopMostTrue()
        {
            TopMost = true;
        }
        void SetTopMostFalse()
        {
            TopMost = false;
        }
    }
}
