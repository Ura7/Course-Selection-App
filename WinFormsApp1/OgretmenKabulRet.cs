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
    public partial class OgretmenKabulRet : Form
    {
        public OgretmenKabulRet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgretmenDersEklemeMenu ogretmenDersEklemeMenu = new OgretmenDersEklemeMenu();
            int kontenjan = 0;
            string ogretmen_ad = "";
            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from ogretmen where sicil_no=@d1", sTUDENTDB.getConnection);
            cmd.Parameters.AddWithValue("@d1", ogr_PaylasilanDegerler.ogr_Username.ToString());

            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                kontenjan = int.Parse(reader["kontenjan_bilgisi"].ToString());
                ogretmen_ad = reader["ogretmen_ad"].ToString();



            }


            sTUDENTDB.closeConnection();
            if (kontenjan > 0)
            {
                sTUDENTDB.openConnection();
                NpgsqlCommand cm = new NpgsqlCommand("insert into ogrencidersleri (okul_no,dersismi,dersid,sicil_no,ogretmen_ad) values (@c1,@c2,@c3,@c4,@c5)", sTUDENTDB.getConnection);
                cm.Parameters.AddWithValue("@c1", textBox1.Text.ToString());
                cm.Parameters.AddWithValue("@c3", textBox5.Text.ToString());
                cm.Parameters.AddWithValue("@c2", textBox6.Text.ToString());
                cm.Parameters.AddWithValue("@c4", ogr_PaylasilanDegerler.ogr_Username.ToString());
                cm.Parameters.AddWithValue("@c5", ogretmen_ad);

                cm.ExecuteNonQuery();
                MessageBox.Show("Ders Ekleme Başarılı");
                kontenjan--;
                sTUDENTDB.closeConnection();
                sTUDENTDB.openConnection();
                NpgsqlCommand cam = new NpgsqlCommand("update ogretmen set kontenjan_bilgisi=@a1 where sicil_no=@a2", sTUDENTDB.getConnection);
                cam.Parameters.AddWithValue("@a1", kontenjan);
                cam.Parameters.AddWithValue("@a2", ogr_PaylasilanDegerler.ogr_Username.ToString());
                cam.ExecuteNonQuery();
                sTUDENTDB.closeConnection();
                sTUDENTDB.openConnection();
                NpgsqlCommand c = new NpgsqlCommand("Delete from dersekleme where okul_no=@s1 and dersid=@s2", sTUDENTDB.getConnection);
                c.Parameters.AddWithValue("@s1", textBox1.Text.ToString());
                c.Parameters.AddWithValue("@s2", textBox5.Text.ToString());
                c.ExecuteNonQuery();
                sTUDENTDB.closeConnection();
               




            }
            else { MessageBox.Show("Kontenjan Sayısını Aştınız"); }

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();
            NpgsqlCommand cam = new NpgsqlCommand("Delete from dersekleme where okul_no=@q1 and dersid=@q2 and sicil_no = @q3", sTUDENTDB.getConnection);
            cam.Parameters.AddWithValue("@q1",textBox1.Text.ToString());
            cam.Parameters.AddWithValue("@q2",textBox5.Text.ToString());
            cam.Parameters.AddWithValue("@q3", ogr_PaylasilanDegerler.ogr_Username.ToString());
            cam.ExecuteNonQuery();
            MessageBox.Show("Başvuru Reddedildi");
           
            sTUDENTDB.closeConnection() ;
        }
    }
}
