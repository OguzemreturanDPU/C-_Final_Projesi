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
    public partial class CalisilanFirmalar : Form
    {
        public CalisilanFirmalar()
        {
            InitializeComponent();
        }

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anaekran fr = new Anaekran();
            fr.Show();
            this.Hide();
        }

        private void koçSeyahatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.flixbus.com.tr");
            label1.Text = "Koç Seyahat";
        }

        private void efeTurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.efetur.com.tr");
            label1.Text = "Efe Tur";
        }

        private void metroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.metroturizm.com.tr");
            label1.Text = "Metro";
        }

        private void özelDiyarbakırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.ozeldiyarbakir.com.tr");
            label1.Text = "Özel Diyarbakır";
        }

        private void özerTurizmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ozerturizm.net");
            label1.Text = "Özer Turizm";
        }

        private void mersinTravelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.obilet.com/otobus-firmalari/mersin-travel");
            label1.Text = "Mersin Travel";
        }

        private void batmanVanTurizmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.obilet.com/otobus-firmalari/batmanvan-turizm");
            label1.Text = "Batman Van Turizm";
        }

        private void ulusoyTurizmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://ulusoy.com.tr");
            label1.Text = "Ulusoy Turizm";
        }

        private void balıkesirHakserTurizmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.balikesirhakserturizm.com.tr");
            label1.Text = "Balıkesir Hakser Turizm";
        }
    }
}
