using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Kuafor
{
    public partial class Boya_Kayit : MetroForm
    {
        public Boya_Kayit()
        {
            InitializeComponent();
        }
        Tanımlamalar t = new Tanımlamalar();
        baglanti bgl = new baglanti();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            t.ınsertcmd = new OleDbCommand("insert into Boyalar(firma_adi,boya_adi) values('" + metroTextBox1.Text + "','" + metroTextBox2.Text + "')",bgl .coni ());
            t.ınsertcmd.ExecuteNonQuery();
            metroTextBox1.Text = ""; metroTextBox2.Text = "";
            this.Close();
        }
    }
}
