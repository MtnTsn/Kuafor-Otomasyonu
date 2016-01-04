using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kuafor
{
    public partial class Youtube : MetroForm
    {
        public Youtube()
        {
            InitializeComponent();
        }
        Tanımlamalar t = new Tanımlamalar();
        private void Youtube_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.youtube.com/yazilimegitim");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Özellik By& Ebubekir Bastama Tarafından geliştirilmiş'dir. \r İletişim Telefonu:05554128854",t.ex);
        }

    }
}
