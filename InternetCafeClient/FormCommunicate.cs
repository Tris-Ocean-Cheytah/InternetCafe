﻿using System;
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
    public partial class FormCommunicate : Form
    {
        public FormCommunicate()
        {
            InitializeComponent();
        }

        private void sendMessBtn_Click(object sender, EventArgs e)
        {

        }

        private void FormCommunicate_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
