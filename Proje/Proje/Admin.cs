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

namespace Proje
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-06G240K\\SQLEXPRESS;Initial Catalog=OtobusSeyahatDB;Integrated Security=True");
        void temizle()
        {
            txtPNR.Text = "";
            txtNereden.Text = "";
            txtNereye.Text = "";
            mskTarih.Text = "";
            txtOtobusFirma.Text = "";
            mskSaat.Text = "";
            txtKoltukNumara.Text = "";
            txtEmail.Text = "";
            txtTelefon.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTC.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtNereden.Focus();
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
            // TODO: Bu kod satırı 'otobusSeyahatDBDataSet1.tbl_OSDB' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_OSDBTableAdapter.Fill(this.otobusSeyahatDBDataSet1.tbl_OSDB);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtMaas_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_OSDBTableAdapter.Fill(this.otobusSeyahatDBDataSet1.tbl_OSDB);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_OSDB (OSNereden,OSNereye,OSOtobusFirma,OSKoltukStil,OSKoltukNumara,OSEmail,OSTelefon,OSAd,OSSoyad,OSTC) values (@p1,@p2,@p4,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtNereden.Text);
            komut.Parameters.AddWithValue("@p2", txtNereye.Text);
            //komut.Parameters.AddWithValue("@p3", mskTarih);
            komut.Parameters.AddWithValue("@p4", txtOtobusFirma.Text);
            //komut.Parameters.AddWithValue("@p5", mskSaat);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.Parameters.AddWithValue("@p7", txtKoltukNumara.Text);
            komut.Parameters.AddWithValue("@p8", txtEmail.Text);
            komut.Parameters.AddWithValue("@p9", txtTelefon.Text);
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
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
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
            txtNereden.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtNereye.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTarih.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtOtobusFirma.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskSaat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtKoltukNumara.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtTelefon.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {

                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From tbl_OSDB Where OSPNR=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtPNR.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Otobüs Seferi Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update tbl_OSDB Set OSNereden=@a1,OSNereye=@a2,OSOtobusFirma=@a3,OSKoltukStil=@a4,OSKoltukNumara=@a5,OSEmail=@a6,OSTelefon=@a7,OSAd=@a8,OSSoyad=@a9,OSTC=@a10 where OSPNR=@a11", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtNereden.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtNereye.Text);
            komutguncelle.Parameters.AddWithValue("@a3", txtOtobusFirma.Text);
            komutguncelle.Parameters.AddWithValue("@a4", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a5", txtKoltukNumara.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtEmail.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtTelefon.Text);
            komutguncelle.Parameters.AddWithValue("@a8", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@a9", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a10", mskTC.Text);
            komutguncelle.Parameters.AddWithValue("@a11", txtPNR.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Otobüs Seferi Güncellendi");
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            Istatistik fr = new Istatistik();
            fr.Show();
        }
    }
}
