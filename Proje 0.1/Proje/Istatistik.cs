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
    public partial class Istatistik : Form
    {
        public Istatistik()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otobus_seyahat_db;Uid=root;Pwd=secret;Port=3307");

        private void Istatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut1 = new MySqlCommand("Select Count(*) From tbl_osdb", baglanti);
            MySqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblToplamKisi.Text = dr1[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            MySqlCommand komut2 = new MySqlCommand("Select Count(*) From tbl_osdb where OSKoltukStil='2+1'", baglanti);
            MySqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lbl1.Text = dr2[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            MySqlCommand komut3 = new MySqlCommand("Select Count(*) From tbl_osdb where OSKoltukStil='2+2'", baglanti);
            MySqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lbl2.Text = dr3[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            MySqlCommand komut4 = new MySqlCommand("Select Count(*) From tbl_sehirler", baglanti);
            MySqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblSehirSayisi.Text = dr4[0].ToString();
            }
            baglanti.Close();
        }
    }
}
