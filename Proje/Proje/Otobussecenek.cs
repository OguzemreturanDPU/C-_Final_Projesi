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
    public partial class Otobussecenek : Form
    {
        public Otobussecenek()
        {
            InitializeComponent();
        }
        public string Nereden;
        public string Nereye;
        public string Tarih;

        private void button1_Click(object sender, EventArgs e)
        {
            Odemebilgileri fr = new Odemebilgileri();
            fr.Nereden = label4.Text;
            fr.Nereye = label5.Text;
            fr.Tarih = label6.Text;
            fr.OtobusFirma = comboBox1.Text;
            fr.Saat = comboBox2.Text;
            fr.KoltukNumara = comboBox3.Text;
            fr.Show();
            this.Hide();
        }

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anaekran fr = new Anaekran();
            fr.Show();
            this.Hide();
        }

        private void Otobussecenek_Load(object sender, EventArgs e)
        {
            label4.Text = Nereden;
            label5.Text = Nereye;
            label6.Text = Tarih;
        }
    }
}
