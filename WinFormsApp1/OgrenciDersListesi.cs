using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class OgrenciDersListesi : Form
    {
        string userID = "";
        public OgrenciDersListesi()
        {
            InitializeComponent();
        }
        public void adiAl(string username1)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            userID = PaylasilanDegerler.Username;
            
            STUDENTDB std = new STUDENTDB();
            
            string sorgu = "select*from ogrencidersleri where okul_no = @username ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, std.getConnection);
            da.SelectCommand.Parameters.AddWithValue("@username",userID);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
