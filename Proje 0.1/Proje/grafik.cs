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
    public partial class grafik : Form
    {
        public grafik()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otobus_seyahat_db;Uid=root;Pwd=secret;Port=3307");
        private void grafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komutg1 = new MySqlCommand("Select OSNereden,Count(*) From tbl_osdb Group By OSNereden", baglanti);
            MySqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Nereden"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();

            baglanti.Open();
            MySqlCommand komutg2 = new MySqlCommand("Select OSNereye,Count(*) From tbl_osdb Group By OSNereye", baglanti);
            MySqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Nereye"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();

            baglanti.Open();
            MySqlCommand komutg3 = new MySqlCommand("Select OSOtobusFirma,Count(*) From tbl_osdb Group By OSOtobusFirma", baglanti);
            MySqlDataReader dr3 = komutg3.ExecuteReader();
            while (dr3.Read())
            {
                chart3.Series["Firmalar"].Points.AddXY(dr3[0], dr3[1]);
            }
            baglanti.Close();
        }
    }
}
