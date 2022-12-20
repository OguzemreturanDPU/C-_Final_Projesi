using System;
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
    public partial class SeyahatBilgi : Form
    {
        public SeyahatBilgi()
        {
            InitializeComponent();
        }

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anaekran fr = new Anaekran();
            fr.Show();
            this.Hide();
        }

        private void geriDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeyahatSorgu fr = new SeyahatSorgu();
            fr.Show();
            this.Hide();
        }
    }
}
