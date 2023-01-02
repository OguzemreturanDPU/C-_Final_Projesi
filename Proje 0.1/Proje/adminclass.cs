using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Proje
{
     internal class adminclass
    {
        public MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otobus_seyahat_db;Uid=root;Pwd=secret;Port=3307");

        public void SehirKaydet(string sehir)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into tbl_sehirler (sehir) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", sehir);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void SehirGuncelle(string pnr,string sehir)
        {
            baglanti.Open();
            MySqlCommand komutguncelle = new MySqlCommand("Update tbl_sehirler Set sehir=@a1 where ID=@a2", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", sehir);
            komutguncelle.Parameters.AddWithValue("@a2", pnr);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        public void SehirSil(string pnr)
        {
            baglanti.Open();
            MySqlCommand komutsil = new MySqlCommand("Delete From tbl_sehirler Where ID=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", pnr);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
        }

    }
}
