using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

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
            SeyahatBilgi fr = new SeyahatBilgi();
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
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez");
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez");
            }
            else if (comboBox2.Text == comboBox1.Text)
            {
                MessageBox.Show("Aynı Şehirler olamaz");
            }
            else
            {
                Otobussecenek fr = new Otobussecenek();
                fr.Nereden = comboBox1.Text;
                fr.Nereye = comboBox2.Text;
                fr.Tarih = dateTimePicker1.Text;
                fr.Show();
                this.Hide();
            }
            
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
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otobus_seyahat_db;Uid=root;Pwd=secret;Port=3307");
            MySqlCommand komut = new MySqlCommand();
            komut.CommandText = "SELECT * FROM tbl_sehirler";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            MySqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["sehir"].ToString());
                comboBox2.Items.Add(dr["sehir"].ToString());
            }
            baglanti.Close();

        }

  
        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
