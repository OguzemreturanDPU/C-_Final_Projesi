﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class SeyahatSorgu : Form
    {
        public SeyahatSorgu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeyahatBilgi fr = new SeyahatBilgi();
            fr.Show();
            this.Hide();
        }

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anaekran fr = new Anaekran();
            fr.Show();
            this.Hide();
        }
    }
}