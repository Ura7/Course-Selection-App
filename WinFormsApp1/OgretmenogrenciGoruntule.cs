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
    public partial class OgretmenogrenciGoruntule : Form
    {
        int a = 0;
        public OgretmenogrenciGoruntule()
        {
            InitializeComponent();
        }

        private void ogr_listele_Button_Click(object sender, EventArgs e)
        {




            STUDENTDB sTUDENTDB = new STUDENTDB();

            string sorgu = "select * from ogrencidersleri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, sTUDENTDB.getConnection);

            DataSet ds = new DataSet();
            da.Fill(ds);
            ogr_goruntule.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            MessageBox.Show("A");


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }
        DataTable dataTable = new DataTable();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            filtre();





        }
        DataView filtre()
        {
            DataView data = new DataView();
            data = dataTable.DefaultView;
            data.RowFilter = "dersnot like '" + textBox1.Text + "%'";
            ogr_goruntule.DataSource = data;

            return data;
        }
        private void OgrenciGoruntule_Load(object sender, EventArgs e)
        {

        }

        private void notsirala_button_Click(object sender, EventArgs e)
        {
            if (a % 2 == 0)
            {
                ogr_goruntule.Sort(ogr_goruntule.Columns[1], ListSortDirection.Ascending);
            }

            else { ogr_goruntule.Sort(ogr_goruntule.Columns[1], ListSortDirection.Descending); }

            a++;
        }

        private void ogr_goruntule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ogr_goruntule_DoubleClick(object sender, EventArgs e)
        {
            STUDENTDB sTUDENTDB = new STUDENTDB();
            OgrenciGoruntule goruntule = new OgrenciGoruntule();
            goruntule.Show(this);

            string ankiogr = ogr_goruntule.CurrentRow.Cells[0].Value.ToString();
            string sorgu = "select * from ogrenci where okul_no=@d1 ";
            NpgsqlDataAdapter goruntule1 = new NpgsqlDataAdapter(sorgu, sTUDENTDB.getConnection);
            goruntule1.SelectCommand.Parameters.AddWithValue("@d1", ogr_goruntule.CurrentRow.Cells[0].Value);
            DataSet ds = new DataSet();
            goruntule1.Fill(ds);
            goruntule.dataogrencigoruntule.DataSource = ds.Tables[0];
        }

        private void OgretmenogrenciGoruntule_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            List<string> list1 = new List<string>();
            STUDENTDB sTUDENTDB = new STUDENTDB();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("select * from ogrencidersleri", sTUDENTDB.getConnection);
            adapter.Fill(dataTable);

            sTUDENTDB.openConnection();
            NpgsqlCommand command = new NpgsqlCommand("select * from ogrenci", sTUDENTDB.getConnection);
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            { list.Add(npgsqlDataReader["okul_no"].ToString()); }

            foreach (var deger in list)
            {
                comboBox1.Items.Add(deger.ToString());
            }
            sTUDENTDB.closeConnection();
            sTUDENTDB.openConnection();
            NpgsqlCommand command1 = new NpgsqlCommand("select * from ogretmendersleri where sicil_no=@s1", sTUDENTDB.getConnection);
            command1.Parameters.AddWithValue("@s1", ogr_PaylasilanDegerler.ogr_Username.ToString());
            NpgsqlDataReader npgsqlDataReader1 = command1.ExecuteReader();
            while (npgsqlDataReader1.Read())
            { list1.Add(npgsqlDataReader1["dersid"].ToString()); }

            foreach (var deger in list1)
            {
                comboBox2.Items.Add(deger.ToString());
            }
            sTUDENTDB.closeConnection();
        }

        private void derseklemeistegi_button_Click(object sender, EventArgs e)
        {
            List<string> istek_ogrenci = new List<string>();
            List<string> istek_ders = new List<string>();
            List<string> varolan_ders = new List<string>();
            string isim = "";
            string ders = "";
            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();
            NpgsqlCommand cm = new NpgsqlCommand("select * from dersekleme where sicil_no=@l1", sTUDENTDB.getConnection);
            cm.Parameters.AddWithValue("@l1", ogr_PaylasilanDegerler.ogr_Username.ToString());
            NpgsqlDataReader readdd = cm.ExecuteReader();
            while (readdd.Read())
            {
                istek_ogrenci.Add(readdd["okul_no"].ToString());
                istek_ders.Add(readdd["dersid"].ToString());
            }
            sTUDENTDB.closeConnection();
            sTUDENTDB.openConnection();
            NpgsqlCommand cm2 = new NpgsqlCommand("select * from ogrencidersleri where okul_no=@l2", sTUDENTDB.getConnection);
            cm2.Parameters.AddWithValue("@l2", comboBox1.Text.ToString());
            NpgsqlDataReader readdd2 = cm2.ExecuteReader();
            while (readdd2.Read())
            {
                varolan_ders.Add(readdd2["dersid"].ToString());
            }

            sTUDENTDB.closeConnection();
            sTUDENTDB.openConnection();
            NpgsqlCommand cm123 = new NpgsqlCommand("select * from ogretmen where sicil_no=@a1", sTUDENTDB.getConnection);
            cm123.Parameters.AddWithValue("@a1", ogr_PaylasilanDegerler.ogr_Username.ToString());
            NpgsqlDataReader reader = cm123.ExecuteReader();
            if (reader.Read())
            { isim = reader["ogretmen_ad"].ToString(); }



            sTUDENTDB.closeConnection();

            sTUDENTDB.openConnection();

            NpgsqlCommand cam = new NpgsqlCommand("select * from dersler where dersid=@a2", sTUDENTDB.getConnection);
            cam.Parameters.AddWithValue("@a2", comboBox2.Text.ToString());
            NpgsqlDataReader read = cam.ExecuteReader();
            if (read.Read())
            {

                ders = read["dersismi"].ToString();
            }

            sTUDENTDB.closeConnection();
            bool eslesmeVar = false;
            bool eslesmeVar1 = false;
            bool eslesmeVar2 = false;
            foreach (var deger in istek_ogrenci)
            {
                if (deger == comboBox1.Text.ToString())
                {
                    eslesmeVar = true;
                    break;
                }
            }
            foreach (var deger in istek_ders)
            {
                if (deger == comboBox2.Text.ToString())
                {
                    eslesmeVar1 = true;
                    break;
                }
            }
            foreach (var deger in varolan_ders)
            {
                if (deger == comboBox2.Text.ToString())
                {
                    eslesmeVar2 = true;
                    break;
                }
            }

            if (!eslesmeVar2)
            {
                if (!eslesmeVar || !eslesmeVar1)
                {
                    sTUDENTDB.openConnection();
                    NpgsqlCommand coma = new NpgsqlCommand("insert into dersekleme(okul_no,sicil_no,ogr_isim,dersid,dersismi,istek) values (@k1,@k2,@k3,@k4,@k5,@k6)", sTUDENTDB.getConnection);
                    coma.Parameters.AddWithValue("@k1", comboBox1.Text.ToString());
                    coma.Parameters.AddWithValue("@k2", ogr_PaylasilanDegerler.ogr_Username.ToString());
                    coma.Parameters.AddWithValue("@k3", isim);
                    coma.Parameters.AddWithValue("@k4", comboBox2.Text.ToString());
                    coma.Parameters.AddWithValue("@k5", ders);
                    coma.Parameters.AddWithValue("@k6", "öğretmen");
                    coma.ExecuteNonQuery();
                    MessageBox.Show("İstek Gönderildi.");
                    sTUDENTDB.closeConnection();

                }
                else { MessageBox.Show("Bu Öğrenci Zaten Bu Derse İstekte Bulunmuş!"); }
            }
            else { MessageBox.Show("Bu Öğrenci Bu Derse Sahip"); }

        }

    }


}
