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
    public partial class Sehiradmin : Form
    {
        public Sehiradmin()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otobus_seyahat_db;Uid=root;Pwd=secret;Port=3307");
        adminclass bagla1 = new adminclass();
        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void Sehiradmin_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from tbl_sehirler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from tbl_sehirler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bagla1.SehirKaydet(textBox1.Text);
            //baglanti.Open();
            //MySqlCommand komut = new MySqlCommand("insert into tbl_sehirler (sehir) values (@p1)", baglanti);
            //komut.Parameters.AddWithValue("@p1", textBox1.Text);
            //komut.ExecuteNonQuery();
            //baglanti.Close();
            MessageBox.Show("Yeni Şehir Kaydedildi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            bagla1.SehirSil(textBox2.Text);
            //baglanti.Open();
            //MySqlCommand komutsil = new MySqlCommand("Delete From tbl_sehirler Where ID=@k1", baglanti);
            //komutsil.Parameters.AddWithValue("@k1", textBox2.Text);
            //komutsil.ExecuteNonQuery();
            //baglanti.Close();
            MessageBox.Show("Şehir Silindi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox2.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bagla1.SehirGuncelle(textBox2.Text, textBox1.Text);
            //baglanti.Open();
            //MySqlCommand komutguncelle = new MySqlCommand("Update tbl_sehirler Set sehir=@a1 where ID=@a2", baglanti);
            //komutguncelle.Parameters.AddWithValue("@a1", textBox1.Text);
            //komutguncelle.Parameters.AddWithValue("@a2", textBox2.Text);
            //komutguncelle.ExecuteNonQuery();
            //baglanti.Close();
            MessageBox.Show("Şehir Güncellendi");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anaekran fr = new Anaekran();
            fr.Show();
            this.Hide();
        }

        private void geriDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin fr = new Admin();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin fr = new Admin();
            fr.Show();
            this.Hide();
        }
    }
}
