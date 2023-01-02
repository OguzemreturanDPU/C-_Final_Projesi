using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Proje
{
    internal class adminfirma
    {
        public MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otobus_seyahat_db;Uid=root;Pwd=secret;Port=3307");

        public void FirmaKaydet(string firma, string fiyat)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into tbl_firmalar (firma,fiyat) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", firma);
            komut.Parameters.AddWithValue("@p2", fiyat);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void FirmaGuncelle(string ID, string firma,string fiyat)
        {
            baglanti.Open();
            MySqlCommand komutguncelle = new MySqlCommand("Update tbl_firmalar Set firma=@a1,fiyat=@a3 where ID=@a2", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", firma);
            komutguncelle.Parameters.AddWithValue("@a2", ID);
            komutguncelle.Parameters.AddWithValue("@a3", fiyat);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        public void FirmaSil(string ID)
        {
            baglanti.Open();
            MySqlCommand komutsil = new MySqlCommand("Delete From tbl_firmalar Where ID=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", ID);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
