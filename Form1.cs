﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtFN.Text == string.Empty || TxtRm.Text == string.Empty)
            {
                MessageBox.Show("Doldurulmayib");
                return;
            }

            Dgv.Rows.Add(TxtFN.Text, TxtRm.Text, TxtDT.Text);
        }

        
    }
}
