using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Kuafor
{
    public partial class iletisim : MetroForm
    {
        public iletisim()
        {
            InitializeComponent();
        }

        private void iletisim_Load(object sender, EventArgs e)
        {
            
            if (Tanımlamalar.adresler != "https://dub112.mail.live.com/?page=Compose")
            {
                webBrowser1.Navigate(Tanımlamalar.adresler.ToString());
                label2.Hide();
                label3.Hide();


            }
            else
            {
                webBrowser1.Navigate(Tanımlamalar.adresler.ToString());
                label1.Hide();
            }

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.elmalicesmekuruyemis.com");
        }
    }
}
