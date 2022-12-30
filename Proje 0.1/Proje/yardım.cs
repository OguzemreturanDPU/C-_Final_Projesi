using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class yardım : Form
    {
        public yardım()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Turan Seyahat üzerinden otobüs bileti satın alırke e-posta adresi, cep telefonu numarası, ad, soyad, T.C.kimlik numarası ve koltuk bilgilerini gerekli yerlere ekleyebilir, ardından kart bilgilerini de girerek satın alma işlemini tamamlayabilirsiniz.");
        }

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anaekran fr = new Anaekran();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otobüs biletinizi satın aldığınız kartın sahibi ve yolcu aynı kişi olmak zorunda değildir.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otobüs seferleri, firmaların belirlediği yolculuk planına göre düzenleniyor. Bu nedenle otobüs şoförünün geciken yolcuları beklemesi mümkün değil. Yolcuların otobüslerinin kalkış saatinden 15 dakika önce otogarda bulunması gerekiyor.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Turan Seyahat’de Pamukkale Turizm, Metro Turizm, Efe Tur, Villa Seyahat ve Süha Turizm gibi ülkemizin farklı şehirlerine sefer düzenleyen birçok otobüs firmasını bulabilirsiniz.");
        }
    }
}
