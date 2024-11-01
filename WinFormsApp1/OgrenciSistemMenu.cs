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
    public partial class OgrenciSistemMenu : Form
    {
        public OgrenciSistemMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciDersListesi ds = new OgrenciDersListesi();
            ds.Show(this);
        }

        private void transkript_Button_Click(object sender, EventArgs e)
        {
            Transkript_yukle trsykl = new Transkript_yukle();
            trsykl.Show(this);
        }

        private void derssec_button_Click(object sender, EventArgs e)
        {
            OgenciDersSec ogenciDersSec = new OgenciDersSec();
            ogenciDersSec.Show(this);


            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();
            string sorgu = "select * from ogretmendersleri ";
            NpgsqlDataAdapter goruntule = new NpgsqlDataAdapter(sorgu, sTUDENTDB.getConnection);
            DataSet ds = new DataSet();
            goruntule.Fill(ds);
            ogenciDersSec.dersec_grid.DataSource = ds.Tables[0];
            sTUDENTDB.closeConnection();

            sTUDENTDB.openConnection();
            string sorgum = "select * from dersekleme where okul_no=@d1";
            NpgsqlDataAdapter goruntule1 = new NpgsqlDataAdapter(sorgum, sTUDENTDB.getConnection);
            goruntule1.SelectCommand.Parameters.AddWithValue("@d1", PaylasilanDegerler.Username.ToString());
            DataSet ds1 = new DataSet();
            goruntule1.Fill(ds1);
            ogenciDersSec.dataGridView1.DataSource = ds1.Tables[0];
            sTUDENTDB.closeConnection();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OgrenciMesaj ogrenciMesaj = new OgrenciMesaj();
            ogrenciMesaj.Show(this);
        }

        private void OgrenciSistemMenu_Load(object sender, EventArgs e)
        {
            if (Asama.Asamam == 2)
            {
                derssec_button.Visible = false;
            }
        }

        private void ogrbilgi_button_Click(object sender, EventArgs e)
        {
            ÖğrenciBilgilerim ogrencibilgi = new ÖğrenciBilgilerim();
            ogrencibilgi.Show(this);

           STUDENTDB sTUDENTDB = new STUDENTDB();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter("select * from ogrenci where okul_no=@s1", sTUDENTDB.getConnection);
            adp.SelectCommand.Parameters.AddWithValue("@s1",PaylasilanDegerler.Username.ToString());    
            DataSet da = new DataSet();
            adp.Fill(da);
            ogrencibilgi.dataGridViewbilgi.DataSource = da.Tables[0];
        }
    }
}
