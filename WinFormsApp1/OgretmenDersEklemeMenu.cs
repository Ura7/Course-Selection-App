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
    public partial class OgretmenDersEklemeMenu : Form
    {
        public OgretmenDersEklemeMenu()
        {
            InitializeComponent();
        }

        private void dataGridView_istek_DoubleClick(object sender, EventArgs e)
        {
            OgretmenKabulRet ogretmenKabulRet = new OgretmenKabulRet();
            ogretmenKabulRet.Show(this);

            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("select * from ogrenci where okul_no=@d1", sTUDENTDB.getConnection);
            npgsqlCommand.Parameters.AddWithValue("@d1", dataGridView_istek.CurrentRow.Cells[0].Value);
            NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();

            if (npgsqlDataReader.Read())
            {
                ogretmenKabulRet.textBox1.Text = npgsqlDataReader["okul_no"].ToString();
                ogretmenKabulRet.textBox2.Text = npgsqlDataReader["ogr_isim"].ToString();
                ogretmenKabulRet.textBox3.Text = npgsqlDataReader["ogr_soyad"].ToString();
                ogretmenKabulRet.textBox4.Text = npgsqlDataReader["ogr_ilgialani"].ToString();

            }
            ogretmenKabulRet.textBox5.Text = dataGridView_istek.CurrentRow.Cells[3].Value.ToString();
            ogretmenKabulRet.textBox6.Text = dataGridView_istek.CurrentRow.Cells[4].Value.ToString();

            sTUDENTDB.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();
            NpgsqlDataAdapter a = new NpgsqlDataAdapter("select * from dersekleme where sicil_no=@a1", sTUDENTDB.getConnection);
            a.SelectCommand.Parameters.AddWithValue("@a1", ogr_PaylasilanDegerler.ogr_Username.ToString());

            DataSet das = new DataSet();
            a.Fill(das);
            dataGridView_istek.DataSource = das.Tables[0];
            sTUDENTDB.closeConnection();


        }

        private void dataGridView_istek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
