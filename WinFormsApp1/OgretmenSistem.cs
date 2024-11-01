using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class OgretmenSistem : Form
    {
        public OgretmenSistem()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            STUDENTDB studentDB = new STUDENTDB();
            string ogrusername = textBox1.Text.ToString();  
            ogr_PaylasilanDegerler.ogr_Username = ogrusername;
            string sorgu = "select * from ogretmen where sicil_no= '" + textBox1.Text + "' and  ogretmen_password='" + textBox2.Text + "'";
            DataTable table = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu, studentDB.getConnection);
            adp.Fill(table);





            if (table.Rows.Count > 0)

            {
                this.DialogResult = DialogResult.OK;
                OgretmenSistemMenu ogretSys = new OgretmenSistemMenu();
                ogretSys.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("INVALID PASSWORD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }

    public static class ogr_PaylasilanDegerler
    {
        public static string ogr_Username { get; set; }
    }
}
