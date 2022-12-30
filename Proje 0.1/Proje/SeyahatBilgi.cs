using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otobus_seyahat_db;Uid=root;Pwd=secret;Port=3307");

            baglanti.Open();
            string kayit = "SELECT * from tbl_osdb where OSTC=@OSTC";
            //musteriler tablosundaki tüm alanları isim parametresi
            MySqlCommand komut = new MySqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@OSTC", textBox1.Text);
            //isim parametremize textbox'dan girilen değeri aktarıyoruz.
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
