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
    public partial class Oksiden_guncelle : MetroForm
    {
        public Oksiden_guncelle()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        Tanımlamalar t = new Tanımlamalar();
        private void Oksiden_guncelle_Load(object sender, EventArgs e)
        {
          gtr();
           
        }
        void gtr()
        {
            try
            {
                t.dt = new DataTable();
                t.adtr = new OleDbDataAdapter("select * from oksidan", bgl.coni());
                t.adtr.Fill(t.dt);
                metroGrid1.DataSource = t.dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, t.ex);
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            t.dt.Clear();
            t.updatecmd = new OleDbCommand("update oksidan set firma_adi='" + metroTextBox1.Text + "',oksidan_adi='" + metroTextBox2.Text + "' where id=" + label3.Text + "", bgl.coni());
            t.updatecmd.ExecuteNonQuery();
            metroTextBox1.Text = ""; metroTextBox2.Text = "";
            MessageBox.Show("Güncelleme Başarılı", t.ex);
            gtr();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label3.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
                metroTextBox1.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
                metroTextBox2.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, t.ex);
            }
        }
    }
}
