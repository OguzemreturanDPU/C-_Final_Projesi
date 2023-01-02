using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Proje
{
    public partial class Otobussecenek : Form
    {
        public Otobussecenek()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otobus_seyahat_db;Uid=root;Pwd=secret;Port=3307");
        public string Nereden;
        public string Nereye;
        public string Tarih;

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez");
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez");
            }
            else if (comboBox3.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez");
            }
            else
            { 
            Odemebilgileri fr = new Odemebilgileri();
            fr.Nereden = label4.Text;
            fr.Nereye = label5.Text;
            fr.Tarih = label6.Text;
            fr.OtobusFirma = comboBox1.Text;
            fr.Saat = comboBox2.Text;
            fr.KoltukNumara = comboBox3.Text;
            fr.KoltukStil = label7.Text;
            fr.Fiyat = label8.Text;
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

        private void Otobussecenek_Load(object sender, EventArgs e)
        {
           

            label4.Text = Nereden;
            label5.Text = Nereye;
            label6.Text = Tarih;

            MySqlCommand komut = new MySqlCommand();
            komut.CommandText = "SELECT * FROM tbl_firmalar";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            MySqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["firma"].ToString());
            }
            baglanti.Close();


   
            MySqlCommand komut1 = new MySqlCommand();
            komut1.CommandText = "SELECT * FROM tbl_saatler";
            komut1.Connection = baglanti;
            komut1.CommandType = CommandType.Text;

            MySqlDataReader dr1;
            baglanti.Open();
            dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox2.Items.Add(dr1["saat"].ToString());
            }
            baglanti.Close();


            MySqlCommand komut2 = new MySqlCommand();
            komut2.CommandText = "SELECT * FROM tbl_koltuk_numara";
            komut2.Connection = baglanti;
            komut2.CommandType = CommandType.Text;

            MySqlDataReader dr2;
            baglanti.Open();
            dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox3.Items.Add(dr2["koltuk_numara"].ToString());
            }
            baglanti.Close();

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label7.Text = "2+1";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label7.Text = "2+2";
            }
        }

        private void label7_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand komut3 = new MySqlCommand();
            komut3.CommandText = "SELECT fiyat FROM tbl_firmalar  ORDER BY ID='" + comboBox1.SelectedIndex.ToString() + "'";
            komut3.Connection = baglanti;
            komut3.CommandType = CommandType.Text;

            MySqlDataReader dr3;
            baglanti.Open();
            dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                label8.Text = dr3["fiyat"].ToString();
            }
            baglanti.Close();
        }
    }
}
