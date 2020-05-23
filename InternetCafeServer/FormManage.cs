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
    public partial class FormManage : Form
    {
        FormCommunicate communicate;
        public FormManage()
        {
            InitializeComponent();
            communicate = new FormCommunicate();
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
