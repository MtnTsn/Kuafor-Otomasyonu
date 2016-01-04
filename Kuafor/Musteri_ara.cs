using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Data.OleDb;

namespace Kuafor
{
    public partial class Musteri_ara : MetroForm
    {
        public Musteri_ara()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        Tanımlamalar t = new Tanımlamalar();
        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_mstr_adi .Text !="" &txt_mstr_soyadi .Text !="")
                {
                  
                    t.select = new OleDbCommand("select * from Musteri_Kayıt where mstr_adi='" + txt_mstr_adi.Text + "' and mstr_syd='" + txt_mstr_soyadi.Text + "'", bgl.coni());
                    OleDbDataReader rdr = t.select.ExecuteReader();
                    while (rdr.Read())
                    {
                        idi.Text = rdr["id"].ToString();
                        metroTextBox1.Text = rdr["mstr_adi"].ToString();
                        metroTextBox2.Text = rdr["mstr_syd"].ToString();
                        metroTextBox3.Text = rdr["bfrm_adi"].ToString();
                        metroTextBox4.Text =rdr["boya_adi"].ToString();
                        metroTextBox5.Text = rdr["boya_nmrs"].ToString();
                        metroTextBox6.Text = rdr["boya_gramı"].ToString();
                        metroTextBox7.Text =rdr["ofrm_adi"].ToString();
                        metroTextBox8.Text =rdr["oksidan_nmrs"].ToString();

                    } 
                }
                else
                {
                    MessageBox.Show("Lütfen İsim Ve Soyisim Alanlarını Boş Bırakmayınız",t.ex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, t.ex);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                t.updatecmd = new OleDbCommand("update Musteri_Kayıt set mstr_adi='"+metroTextBox1 .Text +"',mstr_syd='"+metroTextBox2 .Text +"',bfrm_adi='"+metroTextBox4 .Text +"',boya_adi='"+metroTextBox3 .Text +"',boya_nmrs='"+metroTextBox6 .Text +"',boya_gramı='"+metroTextBox5 .Text +"',ofrm_adi='"+metroTextBox7 .Text +"',oksidan_nmrs='"+metroTextBox8 .Text +"' where id="+idi .Text +"", bgl.coni());
                t.updatecmd.ExecuteNonQuery();
                MessageBox.Show("İşleminiz Başarılı bir şekilde gerçekleşti",t.ex);
                gtr();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, t.ex);
            }
        }
        private void Musteri_ara_Load(object sender, EventArgs e)
        {
            gtr();
        }
        void gtr()
        {
            try
            {
                t.ds = new DataSet();
                t.adtr = new OleDbDataAdapter("select * from Musteri_Kayıt", bgl.coni());
                t.adtr.Fill(t.ds, "Musteri_Kayıt");
                metroGrid1.DataSource = t.ds.Tables["Musteri_Kayıt"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, t.ex);
            }

        }
    }
}
