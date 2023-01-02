using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Proje
{
    internal class Baglan
    {
        public MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otobus_seyahat_db;Uid=root;Pwd=secret;Port=3307");




        public void otobusSeferGuncelle(string nereden, string nereye, string otobusfirna, string label8, string koltuknumara, string email, string telefon, string ad , string soyad, string tc, string pnr, string textbox1, string saat)
        {
            
            baglanti.Open();
            MySqlCommand komutguncelle = new MySqlCommand("Update tbl_osdb Set OSNereden=@a1,OSNereye=@a2,OSOtobusFirma=@a3,OSKoltukStil=@a4,OSKoltukNumara=@a5,OSEmail=@a6,OSTelefon=@a7,OSAd=@a8,OSSoyad=@a9,OSTC=@a10,OSTarih=@a12,OSSaat=@a13 where OSPNR=@a11", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", nereden);
            komutguncelle.Parameters.AddWithValue("@a2", nereye);
            komutguncelle.Parameters.AddWithValue("@a3", otobusfirna);
            komutguncelle.Parameters.AddWithValue("@a4", label8);
            komutguncelle.Parameters.AddWithValue("@a5", koltuknumara);
            komutguncelle.Parameters.AddWithValue("@a6", email);
            komutguncelle.Parameters.AddWithValue("@a7", telefon);
            komutguncelle.Parameters.AddWithValue("@a8", ad);
            komutguncelle.Parameters.AddWithValue("@a9", soyad);
            komutguncelle.Parameters.AddWithValue("@a10", tc);
            komutguncelle.Parameters.AddWithValue("@a11", pnr);
            komutguncelle.Parameters.AddWithValue("@a12", textbox1);
            komutguncelle.Parameters.AddWithValue("@a13", saat);
            komutguncelle.ExecuteNonQuery();
            
            baglanti.Close();



            //baglanti.Open();
            //MySqlCommand komutguncelle = new MySqlCommand("Update tbl_osdb Set OSNereden=@a1,OSNereye=@a2,OSOtobusFirma=@a3,OSKoltukStil=@a4,OSKoltukNumara=@a5,OSEmail=@a6,OSTelefon=@a7,OSAd=@a8,OSSoyad=@a9,OSTC=@a10,OSTarih=@a12,OSSaat=@a13 where OSPNR=@a11", baglanti);
            //komutguncelle.Parameters.AddWithValue("@a1", cmbNereden.Text);
            //komutguncelle.Parameters.AddWithValue("@a2", cmbNereye.Text);
            //komutguncelle.Parameters.AddWithValue("@a3", cmbOtobüsFirma.Text);
            //komutguncelle.Parameters.AddWithValue("@a4", label8.Text);
            //komutguncelle.Parameters.AddWithValue("@a5", cmbKoltukNumara.Text);
            //komutguncelle.Parameters.AddWithValue("@a6", txtEmail.Text);
            //komutguncelle.Parameters.AddWithValue("@a7", mskTelefon.Text);
            //komutguncelle.Parameters.AddWithValue("@a8", txtAd.Text);
            //komutguncelle.Parameters.AddWithValue("@a9", txtSoyad.Text);
            //komutguncelle.Parameters.AddWithValue("@a10", mskTC.Text);
            //komutguncelle.Parameters.AddWithValue("@a11", txtPNR.Text);
            //komutguncelle.Parameters.AddWithValue("@a12", this.textBox1.Text);
            //komutguncelle.Parameters.AddWithValue("@a13", mskSaat.Text);
            //komutguncelle.ExecuteNonQuery();
            //baglanti.Close();

            // MessageBox.Show("Otobüs Seferi Güncellendi");
        }

        public void OtobusSeferKaydet(string nereden, string nereye, string textbox1,  string otobusfirna, string saat, string label8, string koltuknumara, string email, string telefon, string ad, string soyad, string tc)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into tbl_osdb (OSNereden,OSNereye,OSTarih,OSOtobusFirma,OSSaat,OSKoltukStil,OSKoltukNumara,OSEmail,OSTelefon,OSAd,OSSoyad,OSTC) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", baglanti);
            komut.Parameters.AddWithValue("@p1", nereden);
            komut.Parameters.AddWithValue("@p2", nereye);
            komut.Parameters.AddWithValue("@p3", textbox1);
            komut.Parameters.AddWithValue("@p4", otobusfirna);
            komut.Parameters.AddWithValue("@p5", saat);
            komut.Parameters.AddWithValue("@p6", label8);
            komut.Parameters.AddWithValue("@p7", koltuknumara);
            komut.Parameters.AddWithValue("@p8", email);
            komut.Parameters.AddWithValue("@p9", telefon);
            komut.Parameters.AddWithValue("@p10", ad);
            komut.Parameters.AddWithValue("@p11", soyad);
            komut.Parameters.AddWithValue("@p12", tc);
            komut.ExecuteNonQuery();
            baglanti.Close();



            //baglanti.Open();
            //MySqlCommand komut = new MySqlCommand("insert into tbl_osdb (OSNereden,OSNereye,OSTarih,OSOtobusFirma,OSSaat,OSKoltukStil,OSKoltukNumara,OSEmail,OSTelefon,OSAd,OSSoyad,OSTC) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", baglanti);
            //komut.Parameters.AddWithValue("@p1", cmbNereden.Text);
            //komut.Parameters.AddWithValue("@p2", cmbNereye.Text);
            //komut.Parameters.AddWithValue("@p3", textBox1.Text);
            //komut.Parameters.AddWithValue("@p4", cmbOtobüsFirma.Text);
            //komut.Parameters.AddWithValue("@p5", mskSaat.Text);
            //komut.Parameters.AddWithValue("@p6", label8.Text);
            //komut.Parameters.AddWithValue("@p7", cmbKoltukNumara.Text);
            //komut.Parameters.AddWithValue("@p8", txtEmail.Text);
            //komut.Parameters.AddWithValue("@p9", mskTelefon.Text);
            //komut.Parameters.AddWithValue("@p10", txtAd.Text);
            //komut.Parameters.AddWithValue("@p11", txtSoyad.Text);
            //komut.Parameters.AddWithValue("@p12", mskTC.Text);
            //komut.ExecuteNonQuery();
            //baglanti.Close();

        }

        public void OtobusSeferSil(string pnr)
        {
        baglanti.Open();
            MySqlCommand komutsil = new MySqlCommand("Delete From tbl_osdb Where OSPNR=@k1", baglanti);
        komutsil.Parameters.AddWithValue("@k1", pnr);
            komutsil.ExecuteNonQuery();
            baglanti.Close();

            //baglanti.Open();
            //MySqlCommand komutsil = new MySqlCommand("Delete From tbl_osdb Where OSPNR=@k1", baglanti);
            //komutsil.Parameters.AddWithValue("@k1", txtPNR.Text);
            //komutsil.ExecuteNonQuery();
            //baglanti.Close();
        }

    }
}
