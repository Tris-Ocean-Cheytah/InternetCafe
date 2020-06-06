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
    public partial class FormChat : Form
    {
        public FormChat()
        {
            InitializeComponent();
        }

        public FormChat(string s):this()
        {
            this.Text = s;
        }

        private void sendMessBtn_Click(object sender, EventArgs e)
        {

        }

        private void FormChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
