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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        public string asd;
        Baglan bagla = new Baglan();
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otobus_seyahat_db;Uid=root;Pwd=secret;Port=3307");
        void temizle()
        {
            txtPNR.Text = "";
            cmbNereden.Text = "";
            cmbNereye.Text = "";
            textBox1.Text = "";
            cmbOtobüsFirma.Text = "";
            mskSaat.Text = "";
            cmbKoltukNumara.Text = "";
            txtEmail.Text = "";
            mskTelefon.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTC.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            cmbNereden.Focus();
        }
        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anaekran fr = new Anaekran();
            fr.Show();
            this.Hide();
        }

        private void geriDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from tbl_osdb", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

            
            MySqlCommand komut = new MySqlCommand();
            komut.CommandText = "SELECT * FROM tbl_sehirler";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            MySqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbNereden.Items.Add(dr["sehir"].ToString());
            }
            baglanti.Close();


            MySqlCommand komut1 = new MySqlCommand();
            komut1.CommandText = "SELECT * FROM tbl_sehirler";
            komut1.Connection = baglanti;
            komut1.CommandType = CommandType.Text;

            MySqlDataReader dr1;
            baglanti.Open();
            dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmbNereye.Items.Add(dr1["sehir"].ToString());
            }
            baglanti.Close();

            

            MySqlCommand komut2 = new MySqlCommand();
            komut2.CommandText = "SELECT * FROM tbl_firmalar";
            komut2.Connection = baglanti;
            komut2.CommandType = CommandType.Text;

            MySqlDataReader dr2;
            baglanti.Open();
            dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbOtobüsFirma.Items.Add(dr2["firma"].ToString());
            }
            baglanti.Close();


            MySqlCommand komut3 = new MySqlCommand();
            komut3.CommandText = "SELECT * FROM tbl_koltuk_numara";
            komut3.Connection = baglanti;
            komut3.CommandType = CommandType.Text;

            MySqlDataReader dr3;
            baglanti.Open();
            dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbKoltukNumara.Items.Add(dr3["koltuk_numara"].ToString());
            }
            baglanti.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtMaas_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from tbl_osdb", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bagla.OtobusSeferKaydet(cmbNereden.Text, cmbNereye.Text, this.textBox1.Text, cmbOtobüsFirma.Text, mskSaat.Text, label8.Text, cmbKoltukNumara.Text, txtEmail.Text, mskTelefon.Text, txtAd.Text, txtSoyad.Text, mskTC.Text );
            MessageBox.Show("Otobüs Seferi Kaydedildi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "2+1";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "2+2";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtPNR.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbNereden.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbNereye.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            
            cmbOtobüsFirma.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskSaat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            cmbKoltukNumara.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            mskTelefon.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "2+1")
            {

                radioButton1.Checked = true;
            }
            if (label8.Text == "2+2")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bagla.OtobusSeferSil(txtPNR.Text);
            MessageBox.Show("Otobüs Seferi Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bagla.otobusSeferGuncelle(cmbNereden.Text, cmbNereye.Text, cmbOtobüsFirma.Text, label8.Text, cmbKoltukNumara.Text, txtEmail.Text, mskTelefon.Text, txtAd.Text, txtSoyad.Text, mskTC.Text, txtPNR.Text, this.textBox1.Text, mskSaat.Text);
            MessageBox.Show("Otobüs Seferi Güncellendi");
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            Istatistik fr = new Istatistik();
            fr.Show();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            grafik fr = new grafik();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sehiradmin fr = new Sehiradmin();
            fr.Show();
            this.Hide();
        }
    }
}
