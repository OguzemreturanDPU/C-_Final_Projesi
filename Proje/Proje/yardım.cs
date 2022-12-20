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
    public partial class yardım : Form
    {
        public yardım()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("asdasdasdasd");
        }

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anaekran fr = new Anaekran();
            fr.Show();
            this.Hide();
        }
    }
}
