using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Kuafor
{
    public partial class Oksiden : MetroForm
    {
        public Oksiden()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        Tanımlamalar t = new Tanımlamalar();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            t.ınsertcmd = new OleDbCommand("insert into oksidan(firma_adi,oksidan_adi) values('" + metroTextBox1.Text + "','" + metroTextBox2.Text + "')", bgl.coni());
            t.ınsertcmd.ExecuteNonQuery();
            metroTextBox1.Text = ""; metroTextBox2.Text = "";
            MessageBox.Show("Ürün Kaydedildi",t.ex );

        }
    }
}
