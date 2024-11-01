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
    public partial class OgretmenSistemMenu : Form
    {
        public OgretmenSistemMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogretmenilgialani ogretmenilgialani = new Ogretmenilgialani();
            ogretmenilgialani.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgretmenogrenciGoruntule ogretmenogrenciGoruntule = new OgretmenogrenciGoruntule();
            ogretmenogrenciGoruntule.Show(this);
            if(Asama.Asamam==2)
            {
                ogretmenogrenciGoruntule.derseklemeistegi_button.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OgretmenDersEklemeMenu ogretmenDersEklemeMenu = new OgretmenDersEklemeMenu();
            ogretmenDersEklemeMenu.Show(this);


            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from dersekleme where sicil_no = @d1", sTUDENTDB.getConnection);
            da.SelectCommand.Parameters.AddWithValue("@d1", ogr_PaylasilanDegerler.ogr_Username.ToString());
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);

            ogretmenDersEklemeMenu.dataGridView_istek.DataSource = dataSet.Tables[0];
            sTUDENTDB.closeConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgretmenMesajlar ogretmenMesajlar = new OgretmenMesajlar();
            ogretmenMesajlar.Show(this);
        }

        private void OgretmenSistemMenu_Load(object sender, EventArgs e)
        {
            if(Asama.Asamam==2)
            {
                button3.Visible = false;
            }
        }
    }
}
