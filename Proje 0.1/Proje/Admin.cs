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
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into tbl_osdb (OSNereden,OSNereye,OSTarih,OSOtobusFirma,OSSaat,OSKoltukStil,OSKoltukNumara,OSEmail,OSTelefon,OSAd,OSSoyad,OSTC) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbNereden.Text);
            komut.Parameters.AddWithValue("@p2", cmbNereye.Text);
            komut.Parameters.AddWithValue("@p3", textBox1.Text);
            komut.Parameters.AddWithValue("@p4", cmbOtobüsFirma.Text);
           komut.Parameters.AddWithValue("@p5", mskSaat.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.Parameters.AddWithValue("@p7", cmbKoltukNumara.Text);
            komut.Parameters.AddWithValue("@p8", txtEmail.Text);
            komut.Parameters.AddWithValue("@p9", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p10", txtAd.Text);
            komut.Parameters.AddWithValue("@p11", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p12", mskTC.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
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
            baglanti.Open();
            MySqlCommand komutsil = new MySqlCommand("Delete From tbl_osdb Where OSPNR=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtPNR.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Otobüs Seferi Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komutguncelle = new MySqlCommand("Update tbl_osdb Set OSNereden=@a1,OSNereye=@a2,OSOtobusFirma=@a3,OSKoltukStil=@a4,OSKoltukNumara=@a5,OSEmail=@a6,OSTelefon=@a7,OSAd=@a8,OSSoyad=@a9,OSTC=@a10,OSTarih=@a12,OSSaat=@a13 where OSPNR=@a11", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", cmbNereden.Text);
            komutguncelle.Parameters.AddWithValue("@a2", cmbNereye.Text);
            komutguncelle.Parameters.AddWithValue("@a3", cmbOtobüsFirma.Text);
            komutguncelle.Parameters.AddWithValue("@a4", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a5", cmbKoltukNumara.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtEmail.Text);
            komutguncelle.Parameters.AddWithValue("@a7", mskTelefon.Text);
            komutguncelle.Parameters.AddWithValue("@a8", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@a9", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a10", mskTC.Text);
            komutguncelle.Parameters.AddWithValue("@a11", txtPNR.Text);
            komutguncelle.Parameters.AddWithValue("@a12", this.textBox1.Text);
            komutguncelle.Parameters.AddWithValue("@a13", mskSaat.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
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


    }
}
