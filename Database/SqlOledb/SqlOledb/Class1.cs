using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace SqlOledb
{
    public class Class1
    {
        static OleDbCommand cmd = new OleDbCommand(); //cmd for command
        static OleDbConnection cn = new OleDbConnection();  // cn for connection
        static OleDbDataReader dr;
        public static void connection(string path)
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path + ";";
            cmd.Connection = cn;
        }
        public static void Loaddata()
        {

        }

        public static void SqlRequest(String sql)//the command to do a sql instruction named q
        {
            try
            {
                cn.Open();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cn.Close();
                Loaddata();

            }
            catch (Exception e)
            {
                cn.Close();
            }
        }
    }
}
