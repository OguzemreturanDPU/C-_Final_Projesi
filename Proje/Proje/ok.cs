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
    public partial class ok : Form
    {
        public ok()
        {
            InitializeComponent();
        }
        public string Nereden;
        public string Nereye;
        public string Tarih;
        public string OtobusFirma;
        public string Saat;
        public string KoltukStil;
        public string KoltukNumara;
        public string EMail;
        public string Telefon;
        public string Ad;
        public string Soyad;
        public string TC;

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anaekran fr = new Anaekran();
            fr.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ok_Load(object sender, EventArgs e)
        {
        label1.Text = Nereden;
        label2.Text = Nereye;
        label3.Text = Tarih;
            label4.Text = OtobusFirma;
            label5.Text = Saat;
            label6.Text = KoltukStil;
            label7.Text = KoltukNumara;
            label8.Text = EMail;
            label9.Text = Telefon;
            label10.Text = Ad;
            label11.Text = Soyad;
            label12.Text = TC;
    }
    }
}
