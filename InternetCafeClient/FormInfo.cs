using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeClient
{
    public partial class FormInfo : Form
    {
        private string un;
        private string cmnd;
        private string ns;
        private string sdt;
        private int money;

        public FormInfo(string un,string cmnd,string ns,string sdt,int money)
        {
            this.un = un;
            this.cmnd = cmnd;
            this.ns = ns;
            this.sdt = sdt;
            this.money = money;
            InitializeComponent();
            Changeinf();

        }

        private void Changeinf()
        {
            textBox1.Text = un;
            textBox2.Text = cmnd;
            textBox3.Text = ns;
            textBox4.Text = sdt;
            textBox5.Text = money.ToString();
        }
    }
}
