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
        public string KoltukStil;

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
            if (textBox2.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez");
            }
            else if (maskedTextBox3.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez");
            }
            else if (maskedTextBox2.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez");
            }
            else if (maskedTextBox4.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez");
            }
            else if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez");
            }
            else if (maskedTextBox5.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez");
            }
            else
            {      
            YuklemeEkrani fr = new YuklemeEkrani();
            fr.Nereden = label10.Text;
            fr.Nereye = label11.Text;
            fr.Tarih = label12.Text;
            fr.OtobusFirma = label13.Text;
            fr.Saat = label14.Text;
            fr.KoltukNumara = label15.Text;
            fr.KoltukStil = label16.Text;
            fr.EMail = textBox2.Text;
            fr.Telefon = maskedTextBox3.Text;
            fr.Ad = textBox1.Text;
            fr.Soyad = textBox3.Text;
            fr.TC = maskedTextBox2.Text;
            fr.Show();
            this.Hide();
            }
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
            label16.Text = KoltukStil;
            listBox1.Items.Add(Nereden + " - " + Nereye + "  Tarih:" + Tarih + "  Firma:" + OtobusFirma +  "  Saat:" + Saat + "  Koltuk Numara:" + KoltukNumara + "  Koltuk Şekli:" + KoltukStil);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
