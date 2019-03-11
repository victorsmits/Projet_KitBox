using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace OleDbSql
{
    class Class1
    {
        OleDbCommand cmd = new OleDbCommand(); //cmd for command
        OleDbConnection cn = new OleDbConnection();  // cn for connection
        OleDbDataReader dr;
        public void connection(string path)
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source="+ path +";";
            cmd.Connection = cn;
        }
        public void Loaddata()
        {

        }

        public void SqlRequest(String sql)//the command to do a sql instruction named q
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
