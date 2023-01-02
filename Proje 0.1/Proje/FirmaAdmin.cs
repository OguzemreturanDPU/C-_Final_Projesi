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
    public partial class FirmaAdmin : Form
    {
        public FirmaAdmin()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otobus_seyahat_db;Uid=root;Pwd=secret;Port=3307");
        adminfirma bagla1 = new adminfirma();

        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void FirmaAdmin_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from tbl_firmalar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from tbl_firmalar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bagla1.FirmaKaydet(textBox1.Text, textBox3.Text);
            MessageBox.Show("Yeni Firma Kaydedildi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bagla1.FirmaSil(textBox2.Text);
            MessageBox.Show("Firma Silindi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox2.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bagla1.FirmaGuncelle(textBox2.Text, textBox1.Text, textBox3.Text);
            MessageBox.Show("Firma Güncellendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin fr = new Admin();
            fr.Show();
            this.Hide();
        }
    }
}
