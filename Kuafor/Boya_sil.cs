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
    public partial class Boya_sil : MetroForm
    {
        public Boya_sil()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        Tanımlamalar t = new Tanımlamalar();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            t.deletecmd  = new OleDbCommand("delete from Boyalar where id='"+metroGrid1 .CurrentRow .Cells [0].Value .ToString ()+"'",bgl.coni());
            t.deletecmd.ExecuteNonQuery();
            MessageBox.Show("Silme işlemi Başarılı", t.ex);
            gtr();

        }
        void gtr()
        {
            try
            {
                t.dt = new DataTable();
                t.adtr = new OleDbDataAdapter("select * from Boyalar", bgl.coni());
                t.adtr.Fill(t.dt);
                metroGrid1.DataSource = t.dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, t.ex);
            }

        }

        private void Boya_sil_Load(object sender, EventArgs e)
        {
            gtr();
        }
    }
}
