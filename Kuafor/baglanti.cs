using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;

namespace Kuafor
{
    public class baglanti:Tanımlamalar 
    {
        public  OleDbConnection coni()
        {
            con = new OleDbConnection(provider);
            if (con .State ==ConnectionState .Closed )
            {
                con.Open();
            }
            return con;
        }

    }
}
