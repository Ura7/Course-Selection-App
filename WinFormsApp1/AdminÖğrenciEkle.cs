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
    public partial class AdminÖğrenciEkle : Form
    {
        public AdminÖğrenciEkle()
        {
            InitializeComponent();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            STUDENTDB sTUDENTDB = new STUDENTDB();
            List<string> ogr_ders = new List<string>();

            sTUDENTDB.closeConnection();
            sTUDENTDB.openConnection();
            string temp = comboBox4.Text;

            NpgsqlCommand cot2 = new NpgsqlCommand("select * from ogretmendersleri where sicil_no=@d1 ", sTUDENTDB.getConnection);
            cot2.Parameters.AddWithValue("@d1", temp);
            NpgsqlDataReader drr2 = cot2.ExecuteReader();

            while (drr2.Read())
            {
                ogr_ders.Add(drr2["dersid"].ToString());

            }
            foreach (var deger in ogr_ders)
            {
                comboBox3.Items.Add(deger.ToString());
            }
            sTUDENTDB.closeConnection();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            STUDENTDB sTUDENTDB = new STUDENTDB();
            List<string> ogr_ders = new List<string>();
            List<string> ogr_no = new List<string>();
            string ankiders = "";
            string ankiogr = "";
            sTUDENTDB.openConnection() ;
            NpgsqlCommand com = new NpgsqlCommand("select *from dersler where dersid=@a1",sTUDENTDB.getConnection);
            com.Parameters.AddWithValue("@a1", comboBox3.Text);
            NpgsqlDataReader rt = com.ExecuteReader();
            if(rt.Read()) { ankiders = rt["dersismi"].ToString(); }
            sTUDENTDB.closeConnection();
            sTUDENTDB.openConnection();
            NpgsqlCommand com1 = new NpgsqlCommand("select *from ogretmen where sicil_no=@a2", sTUDENTDB.getConnection);
            com1.Parameters.AddWithValue("@a2", comboBox4.Text);
            NpgsqlDataReader rt1 = com1.ExecuteReader();
            if (rt1.Read()) { ankiogr = rt1["ogretmen_ad"].ToString(); }
            sTUDENTDB.closeConnection();





            sTUDENTDB.openConnection();
            NpgsqlCommand cm = new NpgsqlCommand("select * from ogrencidersleri where okul_no=@d1",sTUDENTDB.getConnection);
            cm.Parameters.AddWithValue("@d1", comboBox1.Text);
            NpgsqlDataReader red = cm.ExecuteReader();
            while (red.Read())
            {
                ogr_ders.Add(red["dersid"].ToString());
            }
            bool eslesmeVar = false;
            foreach (var deger in ogr_ders)
            {
                if (deger == comboBox3.Text.ToString())
                {
                    eslesmeVar = true;
                    break;
                }
            }
            sTUDENTDB.closeConnection();
            sTUDENTDB.openConnection();
            if (!eslesmeVar)
            {
                NpgsqlCommand cam = new NpgsqlCommand("insert into ogrencidersleri(okul_no,dersismi,dersid,sicil_no,ogretmen_ad) values(@s1,@s2,@s3,@s4,@s5)", sTUDENTDB.getConnection);
                cam.Parameters.AddWithValue("@s1", comboBox1.Text);
                cam.Parameters.AddWithValue("@s2", ankiders);
                cam.Parameters.AddWithValue("@s3", comboBox3.Text);
                cam.Parameters.AddWithValue("@s4", comboBox4.Text);
                cam.Parameters.AddWithValue("@s5", ankiogr);
                cam.ExecuteNonQuery();
                MessageBox.Show("Başarıyla eklendi");
                sTUDENTDB.closeConnection();

            }
            else { MessageBox.Show("Bu Ders Zaten Eklenmiş"); }


        }
    }
}
