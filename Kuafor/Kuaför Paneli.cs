using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kuafor
{
    public partial class Kuaför_Paneli : MetroForm
    {
        public Kuaför_Paneli()
        {
            InitializeComponent();
        }
        Tanımlamalar t = new Tanımlamalar();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Boya_Kayit bk = new Boya_Kayit();
            bk.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Boya_Guncelle bg = new Boya_Guncelle();
            bg.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Boya_sil bs = new Boya_sil();
            bs.ShowDialog();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Oksiden o = new Oksiden();
            o.ShowDialog();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Oksiden_guncelle og = new Oksiden_guncelle();
            og.ShowDialog();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            Musteri_Giris mg = new Musteri_Giris();
            mg.ShowDialog();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            Musteri_ara ma = new Musteri_ara();
            ma.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Youtube y = new Youtube();
            y.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen Facebook İletişim için Eçk Browser'dan Giriş Yapınız",t.ex);
            Tanımlamalar.adresler = "https://www.facebook.com/profile.php?id=100006479249048";
            iletisim i = new iletisim();
            i.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Tanımlamalar.adresler = "https://twitter.com/ebastama";
            iletisim i = new iletisim();
            i.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Tanımlamalar.adresler = "https://plus.google.com/+Yazilimegitim";
            iletisim i = new iletisim();
            i.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Tanımlamalar.adresler = "https://dub112.mail.live.com/?page=Compose";
            iletisim i = new iletisim();
            i.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Tanımlamalar.adresler = "https://www.facebook.com/profile.php?id=100006479249048";
            iletisim i = new iletisim();
            i.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            Tanımlamalar.adresler = "https://instagram.com/ebubekirbastama/";
            iletisim i = new iletisim();
            i.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            Tanımlamalar.adresler = "https://dub112.mail.live.com/?page=Compose";
            iletisim i = new iletisim();
            i.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Tanımlamalar.adresler = "http://www.youtube.com/yazilimegitim";
            iletisim i = new iletisim();
            i.ShowDialog();
        }

        private void Kuaför_Paneli_Load(object sender, EventArgs e)
        {
            webBrowser1.Hide();
        }

    }
}
