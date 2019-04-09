using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace SqlOledb
{
    public static class Oledb
    {
        public static OleDbCommand cmd = new OleDbCommand(); //cmd for command
        public static OleDbConnection cn = new OleDbConnection();  // cn for connection
        public static OleDbDataReader dr;

        private static string GetRelativePath(string directory)
        {
            char[] test1 = "\\".ToCharArray();
            string[] test = directory.Split(test1);
            string root = test[0];
            string user = test[1];
            string namePC = test[2];
            string dir = root + "\\" + user + "\\" + namePC + "\\";
            return dir;
        }

        public static void Connection()
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= " + GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Database\DB_Lespieces.accdb;";
            cmd.Connection = cn;
        }

        public static string LoadData(string sql)
        {
            string data = "";
            try
            {
                string q = sql;
                cmd.CommandText = q; // execution of a SQL instruction
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        data += dr[0].ToString();
                    }
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception e)
            {
                cn.Close();
            }
            return data;
        }

        public static string SqlRequest(String sql)//the command to do a sql instruction named q
        {
            Connection();
            try
            {
                cn.Open();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cn.Close();
                return LoadData(sql);

            }
            catch (Exception e)
            {
                cn.Close();
            }

            return null;
        }

        public static void SqlRequestInsert(String sql)//the command to do a sql instruction named q
        {
            Connection();
            try
            {
                cn.Open();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception e)
            {
                cn.Close();
            }
        }

        public static void UpdateReservation(int quantity, string stockRef)
        {
            int currentReservation = int.Parse(SqlRequest("SELECT Reservation FROM Piece WHERE Référence = '" + stockRef + "'"));
            int newReservation = currentReservation + quantity;
            SqlRequest("UPDATE Piece SET Reservation = " + newReservation.ToString() + " WHERE Référence = '" + stockRef + "'");
        }

        public static double GetDBPrice(string stockRef)
        {
            string price = SqlRequest("SELECT PrixClient FROM Piece WHERE Référence = '" + stockRef + "'");

            return double.Parse(price);
        }

        public static int GetDBStock(string stockRef)
        {
            string stock = SqlRequest("SELECT Enstock FROM Piece WHERE Référence = '" + stockRef + "'");

            return int.Parse(stock);
        }

        public static List<string> LoadForDistinct(string n)
        {
            List<string> list = new List<string>();
            try
            {
                string q = n;
                cmd.CommandText = q;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(dr[0].ToString());
                    }
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception e)
            {
                cn.Close();
                Console.WriteLine(e.ToString());
            }
            return list;
        }
    }
}
