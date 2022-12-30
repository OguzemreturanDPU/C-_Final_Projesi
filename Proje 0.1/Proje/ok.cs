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
    public partial class ok : Form
    {
        public ok()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otobus_seyahat_db;Uid=root;Pwd=secret;Port=3307");
        public string Nereden;
        public string Nereye;
        public string Tarih;
        public string OtobusFirma;
        public string Saat;
        public string KoltukStil;
        public string KoltukNumara;
        public string EMail;
        public string Telefon;
        public string Ad;
        public string Soyad;
        public string TC;

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anaekran fr = new Anaekran();
            fr.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ok_Load(object sender, EventArgs e)
        {
        label1.Text = Nereden;
        label2.Text = Nereye;
        label3.Text = Tarih;
            label4.Text = OtobusFirma;
            label5.Text = Saat;
            label6.Text = KoltukStil;
            label7.Text = KoltukNumara;
            label8.Text = EMail;
            label9.Text = Telefon;
            label10.Text = Ad;
            label11.Text = Soyad;
            label12.Text = TC;

            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into tbl_osdb (OSNereden,OSNereye,OSTarih,OSOtobusFirma,OSSaat,OSKoltukStil,OSKoltukNumara,OSEmail,OSTelefon,OSAd,OSSoyad,OSTC) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", baglanti);
            komut.Parameters.AddWithValue("@p1", label1.Text);
            komut.Parameters.AddWithValue("@p2", label2.Text);
            komut.Parameters.AddWithValue("@p3", label3.Text);
            komut.Parameters.AddWithValue("@p4", label4.Text);
            komut.Parameters.AddWithValue("@p5", label5.Text);
            komut.Parameters.AddWithValue("@p6", label6.Text);
            komut.Parameters.AddWithValue("@p7", label7.Text);
            komut.Parameters.AddWithValue("@p8", label8.Text);
            komut.Parameters.AddWithValue("@p9", label9.Text);
            komut.Parameters.AddWithValue("@p10", label10.Text);
            komut.Parameters.AddWithValue("@p11", label11.Text);
            komut.Parameters.AddWithValue("@p12", label12.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Otobüs Seferi Kaydedildi");
        }
    }
}
