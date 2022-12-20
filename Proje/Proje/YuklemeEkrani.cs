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
    public partial class YuklemeEkrani : Form
    {
        public YuklemeEkrani()
        {
            InitializeComponent();
        }
        public string Nereden;
        public string Nereye;
        public string Tarih;
        public string OtobusFirma;
        public string Saat;
        public string KoltukNumara;
        public string EMail;
        public string Telefon;
        public string Ad;
        public string Soyad;
        public string TC;
        private void YuklemeEkrani_Load(object sender, EventArgs e)
        {
            label3.Text = Nereden;
            label4.Text = Nereye;
            label5.Text = Tarih;
            label6.Text = OtobusFirma;
            label7.Text = Saat;
            label8.Text = KoltukNumara;
            label9.Text = EMail;
            label10.Text = Telefon;
            label11.Text = Ad;
            label12.Text = Soyad;
            label13.Text = TC;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;

            if (progressBar1.Value % 20 == 10)
            {
                label1.BackColor = Color.Gray;
            }
            if (progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.Orange;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;

            if (progressBar2.Value % 10 == 0)
            {
                label2.BackColor = Color.Orange;
            }
            if (progressBar2.Value % 10 == 5)
            {
                label2.BackColor = Color.Gray;
            }
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                MessageBox.Show("Biletiniz Hazır");
                ok fr = new ok();
                fr.Nereden = label3.Text;
                fr.Nereye = label4.Text;
                fr.Tarih = label5.Text;
                fr.OtobusFirma = label6.Text;
                fr.Saat = label7.Text;
                fr.KoltukNumara = label8.Text;
                fr.EMail = label9.Text;
                fr.Telefon = label10.Text;
                fr.Ad = label11.Text;
                fr.Soyad = label12.Text;
                fr.TC = label13.Text;
                fr.Show();
                this.Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
