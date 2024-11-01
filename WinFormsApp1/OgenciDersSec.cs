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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class OgenciDersSec : Form
    {
        public OgenciDersSec()
        {
            InitializeComponent();
        }

        private void dersec_grid_DoubleClick(object sender, EventArgs e)
        {
            OgrenciDersSecOgretmeniGor ogrenciDersSecOgretmeniGor = new OgrenciDersSecOgretmeniGor();
            ogrenciDersSecOgretmeniGor.Show(this);

            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("Select * from ogretmen where sicil_no=@d1", sTUDENTDB.getConnection);
            cmd.Parameters.AddWithValue("@d1", dersec_grid.CurrentRow.Cells[0].Value);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                ogrenciDersSecOgretmeniGor.textBox1.Text = reader["sicil_no"].ToString();
                ogrenciDersSecOgretmeniGor.textBox2.Text = reader["ogretmen_ad"].ToString();
                ogrenciDersSecOgretmeniGor.textBox3.Text = reader["ogretmen_soyad"].ToString();
                ogrenciDersSecOgretmeniGor.textBox4.Text = reader["ilgi_alani"].ToString();
                ogrenciDersSecOgretmeniGor.textBox5.Text = reader["kontenjan_bilgisi"].ToString();



            }







        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = "";
            string ders = "";
            string derskontrol = "";
            string ogretmenkontrol = "";
            string derskontrol1 = "";

            List<string> derskontroller = new List<string>();
            List<string> ogretmenkontroller = new List<string>();
            List<string> derskontroller1 = new List<string>();

            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();
            NpgsqlCommand cm = new NpgsqlCommand("select * from ogretmen where sicil_no=@a1", sTUDENTDB.getConnection);
            cm.Parameters.AddWithValue("@a1", derssecsicil_text.Text.ToString());
            NpgsqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            { isim = reader["ogretmen_ad"].ToString(); }



            sTUDENTDB.closeConnection();

            sTUDENTDB.openConnection();

            NpgsqlCommand cam = new NpgsqlCommand("select * from dersler where dersid=@a2", sTUDENTDB.getConnection);
            cam.Parameters.AddWithValue("@a2", derssecDersno_text.Text.ToString());
            NpgsqlDataReader read = cam.ExecuteReader();
            if (read.Read())
            {

                ders = read["dersismi"].ToString();
            }

            sTUDENTDB.closeConnection();

            if (isim != "" && ders != "")
            {

                sTUDENTDB.openConnection();
                NpgsqlCommand command1 = new NpgsqlCommand("select * from dersekleme where okul_no=@s1", sTUDENTDB.getConnection);
                command1.Parameters.AddWithValue("@s1", PaylasilanDegerler.Username.ToString());

                NpgsqlDataReader rd = command1.ExecuteReader();
                while (rd.Read())
                {
                    ogretmenkontroller.Add(rd["sicil_no"].ToString());

                    derskontroller.Add(rd["dersid"].ToString());
                }


                sTUDENTDB.closeConnection();
                sTUDENTDB.openConnection();
                NpgsqlCommand cmd2 = new NpgsqlCommand("select * from ogrencidersleri where okul_no=@f1", sTUDENTDB.getConnection);
                cmd2.Parameters.AddWithValue("@f1", PaylasilanDegerler.Username.ToString());

                NpgsqlDataReader ra = cmd2.ExecuteReader();
                while (ra.Read())

                {
                    derskontroller1.Add(ra["dersid"].ToString());
                }
                sTUDENTDB.closeConnection();
                sTUDENTDB.openConnection();

                bool eslesmeVar = false;
                bool eslesmeVar1 = false;
                bool eslesmeVar2 = false;
                foreach (var deger in ogretmenkontroller)
                {
                    if (deger == derssecsicil_text.Text.ToString())
                    {
                        eslesmeVar = true;
                        break;
                    }
                }

                foreach (var deger in derskontroller)
                {
                    if (deger == derssecDersno_text.Text.ToString())
                    {
                        eslesmeVar1 = true;
                        break;
                    }
                }
                foreach (var deger in derskontroller1)
                {
                    if (deger == derssecDersno_text.Text.ToString())
                    {
                        eslesmeVar2 = true;
                        break;
                    }
                }




                if (!eslesmeVar2)
                {
                    if (!eslesmeVar || !eslesmeVar1)
                    {
                        NpgsqlCommand command = new NpgsqlCommand("insert into dersekleme " +
                        "(okul_no,sicil_no,ogr_isim,dersid,dersismi,istek) values (@d1,@d2,@d3,@d4,@d5,@d6)", sTUDENTDB.getConnection);

                        command.Parameters.AddWithValue("@d1", PaylasilanDegerler.Username.ToString());
                        command.Parameters.AddWithValue("@d2", derssecsicil_text.Text.ToString());
                        command.Parameters.AddWithValue("@d3", isim);
                        command.Parameters.AddWithValue("@d4", derssecDersno_text.Text.ToString());
                        command.Parameters.AddWithValue("@d5", ders);
                        command.Parameters.AddWithValue("@d6", "öğrenci");
                        command.ExecuteNonQuery();
                        MessageBox.Show("Başvuru Gönderildi");
                        sTUDENTDB.closeConnection();



                    }

                    else { MessageBox.Show("Bu Kayıt Zaten Oluşturuldu"); }
                }

                else { MessageBox.Show("Bu Ders Listenizde Mevcut"); }
            }






            else { MessageBox.Show("Yanlış Girildi Yeniden Deneyiniz"); }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            STUDENTDB sTUDENTDB = new STUDENTDB();

            string isim = "";
            string ders = "";
            string derskontrol = "";
            string ogretmenkontrol = "";
            string derskontrol1 = "";

            List<string> derskontroller = new List<string>();
            List<string> ogretmenkontroller = new List<string>();
            List<string> derskontroller1 = new List<string>();
            sTUDENTDB.openConnection();
            NpgsqlCommand cm = new NpgsqlCommand("select * from ogretmen where sicil_no=@a1", sTUDENTDB.getConnection);
            cm.Parameters.AddWithValue("@a1", textBox1.Text.ToString());
            NpgsqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            { isim = reader["ogretmen_ad"].ToString(); }



            sTUDENTDB.closeConnection();

            sTUDENTDB.openConnection();

            NpgsqlCommand cam = new NpgsqlCommand("select * from dersler where dersid=@a2", sTUDENTDB.getConnection);
            cam.Parameters.AddWithValue("@a2", textBox2.Text.ToString());
            NpgsqlDataReader read = cam.ExecuteReader();
            if (read.Read())
            {

                ders = read["dersismi"].ToString();
            }

            sTUDENTDB.closeConnection();



            if (isim != "" && ders != "")
            {

                sTUDENTDB.openConnection();
                NpgsqlCommand command1 = new NpgsqlCommand("select * from dersekleme where okul_no=@s1", sTUDENTDB.getConnection);
                command1.Parameters.AddWithValue("@s1", PaylasilanDegerler.Username.ToString());

                NpgsqlDataReader rd = command1.ExecuteReader();
                while (rd.Read())
                {
                    ogretmenkontroller.Add(rd["sicil_no"].ToString());

                    derskontroller.Add(rd["dersid"].ToString());
                }


                sTUDENTDB.closeConnection();
                sTUDENTDB.openConnection();
                NpgsqlCommand cmd2 = new NpgsqlCommand("select * from ogrencidersleri where okul_no=@f1", sTUDENTDB.getConnection);
                cmd2.Parameters.AddWithValue("@f1", PaylasilanDegerler.Username.ToString());

                NpgsqlDataReader ra = cmd2.ExecuteReader();
                while (ra.Read())

                {
                    derskontroller1.Add(ra["dersid"].ToString());

                }

                bool eslesmeVar = false;
                bool eslesmeVar1 = false;
                bool eslesmeVar2 = false;
                foreach (var deger in ogretmenkontroller)
                {
                    if (deger == textBox1.Text.ToString())
                    {
                        eslesmeVar = true;
                        break;
                    }
                }

                foreach (var deger in derskontroller)
                {
                    if (deger == textBox2.Text.ToString())
                    {
                        eslesmeVar1 = true;
                        break;
                    }
                }
                foreach (var deger in derskontroller1)
                {
                    if (deger == textBox2.Text.ToString())
                    {
                        eslesmeVar2 = true;
                        break;
                    }
                }


                sTUDENTDB.closeConnection();
                sTUDENTDB.openConnection();
                string istek = "";
                NpgsqlCommand sil = new NpgsqlCommand("select * from dersekleme where sicil_no=@v1 and dersid=@v2", sTUDENTDB.getConnection);
                sil.Parameters.AddWithValue("@v1", textBox1.Text.ToString());
                sil.Parameters.AddWithValue("@v2", textBox2.Text.ToString());
                NpgsqlDataReader rddd = sil.ExecuteReader();
                if (rddd.Read()) { istek = rddd["istek"].ToString(); }


                sTUDENTDB.closeConnection();
                sTUDENTDB.openConnection();



                if (eslesmeVar == true && eslesmeVar1 == true && eslesmeVar2 == false)
                {
                    if (istek == "öğrenci")
                    {
                        NpgsqlCommand comm = new NpgsqlCommand("delete from dersekleme where okul_no=@g1 and sicil_no=@g2 and dersid=@g3", sTUDENTDB.getConnection);
                        comm.Parameters.AddWithValue("@g1", PaylasilanDegerler.Username.ToString());
                        comm.Parameters.AddWithValue("@g2", textBox1.Text.ToString());
                        comm.Parameters.AddWithValue("@g3", textBox2.Text.ToString());
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Ders Başvurusu İptal Edildi");
                        sTUDENTDB.closeConnection();
                    }
                    else { MessageBox.Show("Öğretmenin İsteği Silinemez"); }

                }
                else { MessageBox.Show("Kayıt Zaten Silinmiş"); }

            }

            else { MessageBox.Show("Kayıt Yok"); }











        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            OgretmenDersEklemeMenu ogretmenDersEklemeMenu = new OgretmenDersEklemeMenu();
            int kontenjan = 0;
            string ogretmen_ad = "";
            string ders_ad = "";
            string istek = "";
            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from ogretmen where sicil_no=@d1", sTUDENTDB.getConnection);
            cmd.Parameters.AddWithValue("@d1", dataGridView1.CurrentRow.Cells[1].Value.ToString());

            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                kontenjan = int.Parse(reader["kontenjan_bilgisi"].ToString());
                ogretmen_ad = reader["ogretmen_ad"].ToString();



            }


            sTUDENTDB.closeConnection();
            



            sTUDENTDB.openConnection();
            NpgsqlCommand cmer = new NpgsqlCommand("select * from dersler where dersid=@e1",sTUDENTDB.getConnection);
            cmer.Parameters.AddWithValue("@e1", dataGridView1.CurrentRow.Cells[3].Value.ToString());
            NpgsqlDataReader reat = cmer.ExecuteReader();
            if (reat.Read())
            {
                ders_ad = reat["dersismi"].ToString();
            }


            sTUDENTDB.closeConnection();
            sTUDENTDB.openConnection();
            NpgsqlCommand cor = new NpgsqlCommand("select * from dersekleme where sicil_no = @a1 and dersid=@a2 and okul_no=@a3",sTUDENTDB.getConnection);
            cor.Parameters.AddWithValue("@a1", dataGridView1.CurrentRow.Cells[1].Value.ToString());
            cor.Parameters.AddWithValue("@a2", dataGridView1.CurrentRow.Cells[3].Value.ToString());
            cor.Parameters.AddWithValue("@a3", PaylasilanDegerler.Username.ToString());
            NpgsqlDataReader ror = cor.ExecuteReader();
            if (ror.Read()) 
            {
                istek = ror["istek"].ToString();
            }
            sTUDENTDB.closeConnection();

            if (kontenjan > 0 && istek == "öğretmen")
            {
                sTUDENTDB.openConnection();
                NpgsqlCommand cm = new NpgsqlCommand("insert into ogrencidersleri (okul_no,dersismi,dersid,sicil_no,ogretmen_ad) values (@c1,@c2,@c3,@c4,@c5)", sTUDENTDB.getConnection);
                cm.Parameters.AddWithValue("@c1", PaylasilanDegerler.Username.ToString());
                cm.Parameters.AddWithValue("@c3", dataGridView1.CurrentRow.Cells[3].Value.ToString());
                cm.Parameters.AddWithValue("@c2", ders_ad);
                cm.Parameters.AddWithValue("@c4", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                cm.Parameters.AddWithValue("@c5", ogretmen_ad);

                cm.ExecuteNonQuery();
                MessageBox.Show("Ders Ekleme Başarılı");
                kontenjan--;
                sTUDENTDB.closeConnection();
                sTUDENTDB.openConnection();
                NpgsqlCommand cam = new NpgsqlCommand("update ogretmen set kontenjan_bilgisi=@a1 where sicil_no=@a2", sTUDENTDB.getConnection);
                cam.Parameters.AddWithValue("@a1", kontenjan);
                cam.Parameters.AddWithValue("@a2", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                cam.ExecuteNonQuery();
                sTUDENTDB.closeConnection();
                sTUDENTDB.openConnection();
                NpgsqlCommand c = new NpgsqlCommand("Delete from dersekleme where okul_no=@s1 and dersid=@s2", sTUDENTDB.getConnection);
                c.Parameters.AddWithValue("@s1", PaylasilanDegerler.Username.ToString());
                c.Parameters.AddWithValue("@s2", dataGridView1.CurrentRow.Cells[3].Value.ToString());
                c.ExecuteNonQuery();
                sTUDENTDB.closeConnection();





            }
            else { MessageBox.Show("Bu ders kabul edilemez"); }
        }
    }
}
