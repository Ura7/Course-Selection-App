using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
   
    public partial class OgrenciSistem : Form
    {
        public OgrenciSistem()
        {
            InitializeComponent();
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            STUDENTDB studentDB = new STUDENTDB();
            string username = textBox1.Text.ToString();
            PaylasilanDegerler.Username = username; 

            string sorgu = "select * from ogrenci where okul_no= '" + textBox1.Text + "' and  ogr_password='" + textBox2.Text + "'";
            DataTable table = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu, studentDB.getConnection);
            adp.Fill(table);
           

           


            if (table.Rows.Count > 0)

            {
               this.DialogResult = DialogResult.OK;
               OgrenciSistemMenu ogrSys =   new OgrenciSistemMenu();
                ogrSys.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("INVALID PASSWORD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
    public static class PaylasilanDegerler
    {
        public static string Username { get; set; }
    }
}