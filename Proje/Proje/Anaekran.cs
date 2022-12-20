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
    public partial class Anaekran : Form
    {
        public Anaekran()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label5.Text;
        }

        private void seyahatlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeyahatSorgu fr = new SeyahatSorgu();
            fr.Show();
            this.Hide();
        }

        private void çalıştığımızFirmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalisilanFirmalar fr = new CalisilanFirmalar();
            fr.Show();
            this.Hide();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yardım fr = new yardım();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            Otobussecenek fr = new Otobussecenek();
            fr.Nereden = comboBox1.Text;
            fr.Nereye = comboBox2.Text;
            fr.Tarih = maskedTextBox1.Text;
            fr.Show();
            this.Hide();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Anaekran_Load(object sender, EventArgs e)
        {

        }
    }
}
