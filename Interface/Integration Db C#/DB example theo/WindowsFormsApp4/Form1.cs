using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbCommand cmd = new OleDbCommand(); //cmd for command
        OleDbConnection cn = new OleDbConnection();  // cn for connection
        OleDbDataReader dr;

        private void Form1_Load(object sender, EventArgs e) //Connection to the DB and loading the data into the box
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=E:\Bureau\11.accdb;";
            cmd.Connection = cn;
            Loaddata();

        }


        private void Loaddata() //Different Listbox containing the 2 first colomns of the db 
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            try
            {
                string q = "select * from dal";
                cmd.CommandText = q; // execution of a SQL instruction
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listBox1.Items.Add(dr[0].ToString());
                        listBox2.Items.Add(dr[1].ToString());
                    }
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception e)
            {
                cn.Close();
                MessageBox.Show(e.Message.ToString());
            }
        }



        private void listBox2_Click(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                textBox2.Text = listBox2.SelectedItem.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)//boutton inser
        {
            if (textBox1.Text != "") 
            {
                string q = "insert into dal (Référence,Prenom_cm,saucisson) values ('" + textBox1.Text.ToString() + "','MICHEL','sdf')";
                dosomething(q);
                MessageBox.Show(q);
                textBox1.Text = null;
            }
        }
        private void dosomething(String q)//the command to do a sql instruction named q
        {
            try
            {
                cn.Open();
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                cn.Close();
                Loaddata();

            }
            catch (Exception e)
            {
                cn.Close();
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)//butoon delete
        {
            if (listBox1.SelectedIndex != -1)
            {
                string q ="delete from Table1 where Id="+ listBox1.SelectedItem.ToString();
                dosomething(q);
            }
        }

        private void button3_Click(object sender, EventArgs e)//button update
        {
            if (textBox2.Text != "" & listBox1.SelectedIndex != -1)
            {
                string q = "update Table1 set Nom='" + textBox2.Text.ToString() + "' where Id=" + listBox1.SelectedItem.ToString();
                dosomething(q);
                textBox2.Text = "";
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
