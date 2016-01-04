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
    public partial class Musteri_Giris : MetroForm
    {
        public Musteri_Giris()
        {
            InitializeComponent();
        }
        Tanımlamalar t = new Tanımlamalar();
        baglanti bgl = new baglanti();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                t.ınsertcmd = new OleDbCommand("insert into Musteri_Kayıt(mstr_adi,mstr_syd,bfrm_adi,boya_adi,boya_nmrs,boya_gramı,ofrm_adi,oksidan_nmrs) values('" + metroTextBox1.Text + "','" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','" + metroTextBox4.Text + "','" + metroTextBox5.Text + "','" + metroTextBox6.Text + "','" + metroTextBox7.Text + "','" + metroTextBox8.Text + "')", bgl.coni());
                t.ınsertcmd.ExecuteNonQuery();
                base.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message ,t.ex );
            }
        }

        private void Musteri_Giris_Load(object sender, EventArgs e)
        {
            try
            {

                t.select = new OleDbCommand("SELECT Boyalar.firma_adi,Boyalar.boya_adi,oksidan.firma_adi,oksidan.oksidan_adi from Boyalar INNER JOIN oksidan ON Boyalar.id = oksidan.id", bgl.coni());
                OleDbDataReader rdr = t.select.ExecuteReader();
                while (rdr.Read())
                {

                    metroTextBox4.Items.Add(rdr["Boyalar.firma_adi"].ToString());
                    metroTextBox3.Items.Add(rdr["boya_adi"].ToString());
                    metroTextBox7.Items.Add(rdr["oksidan.firma_adi"].ToString());
                    metroTextBox8.Items.Add(rdr["oksidan_adi"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, t.ex);
            }
        }

   
    }
}
