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
    public partial class Odemebilgileri : Form
    {
        public Odemebilgileri()
        {
            InitializeComponent();
        }
        public string Nereden;
        public string Nereye;
        public string Tarih;
        public string OtobusFirma;
        public string Saat;
        public string KoltukNumara;

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text + " Tarih:  " + dateTimePicker1.Text + "Saat: " + maskedTextBox1.Text + "Yolcu Bilgileri // Ad: " + textBox1.Text + "TC: " + maskedTextBox2.Text + "Telefon " + maskedTextBox3.Text);
            YuklemeEkrani fr = new YuklemeEkrani();
            fr.Nereden = label10.Text;
            fr.Nereye = label11.Text;
            fr.Tarih = label12.Text;
            fr.OtobusFirma = label13.Text;
            fr.Saat = label14.Text;
            fr.KoltukNumara = label15.Text;
            fr.EMail = textBox2.Text;
            fr.Telefon = maskedTextBox3.Text;
            fr.Ad = textBox1.Text;
            fr.Soyad = textBox3.Text;
            fr.TC = maskedTextBox2.Text;
            fr.Show();
            this.Hide();
        }

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anaekran fr = new Anaekran();
            fr.Show();
            this.Hide();
        }

        private void geriDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otobussecenek fr = new Otobussecenek();
            fr.Show();
            this.Hide();
        }

        private void Odemebilgileri_Load(object sender, EventArgs e)
        {
            label10.Text = Nereden;
            label11.Text = Nereye;
            label12.Text = Tarih;
            label13.Text = OtobusFirma;
            label14.Text = Saat;
            label15.Text = KoltukNumara;
            listBox1.Items.Add(Nereden + "Nereye: " + Nereye + "Tarih: " + Tarih + "OtobusFirma: " + OtobusFirma + "Saat: " + Saat + "KoltukNumara: " + KoltukNumara);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
