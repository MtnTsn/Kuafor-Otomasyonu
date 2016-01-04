using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;

namespace Kuafor
{
    public class Tanımlamalar
    {
        public string ex = "Ebubekir Bastama Kuaför Programı";
        public string provider ="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Kuaför.accdb";
        public OleDbConnection con;
        public OleDbCommand select;
        public OleDbCommand ınsertcmd;
        public OleDbCommand updatecmd;
        public OleDbCommand deletecmd;
        public OleDbDataAdapter adtr;
        public DataTable dt;
        public DataSet ds;
        public static string adresler;
    }
}
