using Npgsql;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class AdminSistemMenu : Form
    {
        public AdminSistemMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminOgrenciGuncelle adminOgrenciGuncelle = new AdminOgrenciGuncelle();
            adminOgrenciGuncelle.Show(this);

            STUDENTDB sTUDENTDB = new STUDENTDB();
            string sorgu = "select * from ogrenci ";
            NpgsqlDataAdapter goruntule = new NpgsqlDataAdapter(sorgu, sTUDENTDB.getConnection);
            DataSet ds = new DataSet();
            goruntule.Fill(ds);
            adminOgrenciGuncelle.adminogr_data.DataSource = ds.Tables[0];
        }

        private void ogrtmn_button_Click(object sender, EventArgs e)
        {
            AdminOgretmenGuncelle adminOgretmenGuncelle = new AdminOgretmenGuncelle();
            adminOgretmenGuncelle.Show(this);

            STUDENTDB sTUDENTDB = new STUDENTDB();
            string sorgu = "select * from ogretmen ";
            NpgsqlDataAdapter goruntule = new NpgsqlDataAdapter(sorgu, sTUDENTDB.getConnection);
            DataSet ds = new DataSet();
            goruntule.Fill(ds);
            adminOgretmenGuncelle.ogretmen_data.DataSource = ds.Tables[0];

        }

        private void randomogrbutton_Click(object sender, EventArgs e)
        {
            STUDENTDB sTUDENTDB = new STUDENTDB();
            int a = 50;
            int b = 5;
            int ogr = 10010;
            string[] isimler = { "Ali", "Ahmet", "Veli", "Mert", "Mehmet", "Berk", "Burcu", "Gamze", "Muazzez", "Giray", "Veli", "Oğuz", "Yağızhan", "Nazlı", "Sinem", "Emin" };
            string[] soyisim = { "Murat", "Bayrak", "Yılmaz", "Zor", "Sütçü", "İskambil", "Burun", "Türker", "Özgün", "Vural", "Koç", "Kılıç", "Birim", "Fakiroğlu", "Yağız", "Zorlu", "Beyazpınar" };
            string[] dersNotu = { "AA", "BA", "BB", "CB", "CC", "DC" };
            List<string> dersler = new List<string>();
            string tutucu = "";
            string tutucu2 = "";
            string dersismi = "";
            Random random = new Random();
            sTUDENTDB.openConnection();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from dersler where donem=@c1", sTUDENTDB.getConnection);
            cmd.Parameters.AddWithValue("@c1", "1.Dönem");
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dersler.Add(reader["dersid"].ToString());


            }
            sTUDENTDB.closeConnection();


            while (a > 0)
            {
                string isimsec = isimler[new Random().Next(isimler.Length)];
                string soyisimsec = soyisim[new Random().Next(soyisim.Length)];
                sTUDENTDB.openConnection();
                NpgsqlCommand cd = new NpgsqlCommand("insert into ogrenci(okul_no,ogr_isim,ogr_soyad,ogr_password) values (@d1,@d2,@d3,@d4)", sTUDENTDB.getConnection);
                cd.Parameters.AddWithValue("@d1", ogr.ToString());
                cd.Parameters.AddWithValue("@d2", isimsec);
                cd.Parameters.AddWithValue("@d3", soyisimsec);
                cd.Parameters.AddWithValue("@d4", ogr.ToString());
                cd.ExecuteNonQuery();
                sTUDENTDB.closeConnection();

                sTUDENTDB.openConnection();



                while (b > 0)
                {
                    tutucu = tutucu2;

                    do
                    {
                        tutucu2 = dersler[random.Next(dersler.Count)];

                    } while (tutucu2 == tutucu);
                    NpgsqlCommand command = new NpgsqlCommand("select * from dersler where dersid=@s1", sTUDENTDB.getConnection);
                    command.Parameters.AddWithValue("@s1", tutucu2);
                    NpgsqlDataReader re = command.ExecuteReader();
                    if (re.Read())
                    {
                        dersismi = re["dersismi"].ToString();
                    }

                    string dersnot = dersNotu[new Random().Next(dersNotu.Length)];
                    sTUDENTDB.closeConnection();
                    sTUDENTDB.openConnection();
                    NpgsqlCommand cs = new NpgsqlCommand("insert into ogrencidersleri(okul_no,dersnot,dersismi,dersid) values (@f1,@f2,@f3,@f4)", sTUDENTDB.getConnection);
                    cs.Parameters.AddWithValue("@f1", ogr.ToString());
                    cs.Parameters.AddWithValue("@f2", dersnot);
                    cs.Parameters.AddWithValue("@f3", dersismi);
                    cs.Parameters.AddWithValue("@f4", tutucu2);
                    cs.ExecuteNonQuery();
                    b--;

                }
                tutucu = "";
                tutucu2 = "";


                a--;
                ogr++;
                b = 2;
            }
        }





        private void ikinciasamabutton_Click(object sender, EventArgs e)
        {
            Asama.Asamam = 2;




            List<string> acilan_dersler = new List<string>();
            List<string> dersin_ogretmeni = new List<string>();
            List<string> ogrenci = new List<string>();
            List<string> ders_kontrol = new List<string>();
            string temp = "";
            string temp1 = "";
            string temp2 = "";
            int c = 0;
            int c1 = 0;
            string ders_ismi = "";
            string ogr_ismi = "";

            Random random = new Random();
            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();
            NpgsqlCommand cdm = new NpgsqlCommand("select*from ogrenci", sTUDENTDB.getConnection);
            NpgsqlDataReader cdm2 = cdm.ExecuteReader();
            while (cdm2.Read())
            {
                ogrenci.Add(cdm2["okul_no"].ToString());
            }
            sTUDENTDB.closeConnection();

            sTUDENTDB.openConnection();
            NpgsqlCommand cs = new NpgsqlCommand("select * from dersler where donem=@d1", sTUDENTDB.getConnection);
            cs.Parameters.AddWithValue("@d1", "2.Dönem");
            NpgsqlDataReader rd = cs.ExecuteReader();
            while (rd.Read())
            {
                acilan_dersler.Add(rd["dersid"].ToString());
            }
            sTUDENTDB.closeConnection();



            while (acilan_dersler.Count > c)
            {
                temp = acilan_dersler[c].ToString();
                sTUDENTDB.openConnection();
                NpgsqlCommand np = new NpgsqlCommand("select * from dersler where dersid=@f1", sTUDENTDB.getConnection);
                np.Parameters.AddWithValue("@f1", temp);
                NpgsqlDataReader read = np.ExecuteReader();
                if (read.Read())
                {
                    ders_ismi = read["dersismi"].ToString();
                }
                sTUDENTDB.closeConnection();
                sTUDENTDB.openConnection();
                NpgsqlCommand cd = new NpgsqlCommand("select * from ogretmendersleri where dersid=@d2", sTUDENTDB.getConnection);
                cd.Parameters.AddWithValue("@d2", temp);
                NpgsqlDataReader cd2 = cd.ExecuteReader();
                while (cd2.Read())
                {
                    dersin_ogretmeni.Add(cd2["sicil_no"].ToString());
                }
                sTUDENTDB.closeConnection();

                while (ogrenci.Count > c1)
                {
                    temp1 = ogrenci[c1].ToString();

                    temp2 = dersin_ogretmeni[random.Next(dersin_ogretmeni.Count)].ToString();

                    sTUDENTDB.openConnection();
                    NpgsqlCommand commm = new NpgsqlCommand("select * from ogretmen where sicil_no=@h1", sTUDENTDB.getConnection);
                    commm.Parameters.AddWithValue("@h1", temp2);
                    NpgsqlDataReader readd = commm.ExecuteReader();
                    if (readd.Read()) { ogr_ismi = readd["ogretmen_ad"].ToString(); }


                    sTUDENTDB.closeConnection();
                    sTUDENTDB.openConnection();
                    NpgsqlCommand ck = new NpgsqlCommand("select * from ogrencidersleri where okul_no=@c1", sTUDENTDB.getConnection);
                    ck.Parameters.AddWithValue("@c1", temp1);
                    NpgsqlDataReader ck2 = ck.ExecuteReader();
                    while (ck2.Read())
                    {
                        ders_kontrol.Add(ck2["dersid"].ToString());
                    }
                    sTUDENTDB.closeConnection();
                    bool eslesmeVar = false;
                    foreach (var deger in ders_kontrol)
                    {
                        if (deger == temp)
                        {
                            eslesmeVar = true;
                            break;
                        }
                    }

                    if (!eslesmeVar)
                    {
                        sTUDENTDB.openConnection();
                        NpgsqlCommand npg = new NpgsqlCommand("insert into ogrencidersleri(okul_no,dersismi,dersid,sicil_no,ogretmen_ad) values (@s1,@s2,@s3,@s4,@s5)", sTUDENTDB.getConnection);
                        npg.Parameters.AddWithValue("@s1", temp1);
                        npg.Parameters.AddWithValue("@s2", ders_ismi);
                        npg.Parameters.AddWithValue("@s3", temp);
                        npg.Parameters.AddWithValue("@s4", temp2);
                        npg.Parameters.AddWithValue("@s5", ogr_ismi);
                        npg.ExecuteNonQuery();
                        sTUDENTDB.closeConnection();
                        c1++;


                    }
                    else { c1++; eslesmeVar = false; }



                }
                dersin_ogretmeni.Clear();
                c1 = 0;
                c++;



            }
            MessageBox.Show("Öğrenciler Rastgele Bir Şekilde Dersin Öğretmenlerine Atandı");

        }


        private void AdminSistemMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminÖğrenciEkle adminEKLE = new AdminÖğrenciEkle();
            adminEKLE.Show(this);
            List<string> ogrenci = new List<string>();
            List<string> ogretmen = new List<string>();
           
            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();
            NpgsqlCommand cot = new NpgsqlCommand("select * from ogrenci ",sTUDENTDB.getConnection);
            NpgsqlDataReader drr = cot.ExecuteReader();
            
            while(drr.Read()) 
            {
                ogrenci.Add(drr["okul_no"].ToString());
            }
            foreach (var deger in ogrenci)
            {
                adminEKLE.comboBox1.Items.Add(deger.ToString());
            }
            sTUDENTDB.closeConnection();
            sTUDENTDB.openConnection();
            NpgsqlCommand cot1 = new NpgsqlCommand("select * from ogretmen ", sTUDENTDB.getConnection);
            NpgsqlDataReader drr1 = cot1.ExecuteReader();
            
            while (drr1.Read())
            {
                ogretmen.Add(drr1["sicil_no"].ToString());
            }
            foreach (var deger in ogretmen)
            {
                adminEKLE.comboBox4.Items.Add(deger.ToString());
            }

            
            


        }
    }


    public static class Asama
    {
        public static int Asamam { get; set; }
    }
}
