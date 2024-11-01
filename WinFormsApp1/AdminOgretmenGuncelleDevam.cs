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
    public partial class AdminOgretmenGuncelleDevam : Form
    {
        public AdminOgretmenGuncelleDevam()
        {
            InitializeComponent();
        }

        private void guncelle_button_Click(object sender, EventArgs e)
        {
            STUDENTDB sTUDENTDB = new STUDENTDB();


            sTUDENTDB.openConnection();
            NpgsqlCommand cmd = new NpgsqlCommand("update ogretmen set ogretmen_ad=@d1, ogretmen_soyad=@d2, ilgi_alani=@d3, kontenjan_bilgisi=@d4, ogretmen_password=@d5 where sicil_no = @d6", sTUDENTDB.getConnection);
            cmd.Parameters.AddWithValue("@d1", textBoxogrtisim.Text);
            cmd.Parameters.AddWithValue("@d2", textBoxogrtsoy.Text);
            cmd.Parameters.AddWithValue("@d3", textBoxilgialani.Text);
            cmd.Parameters.AddWithValue("@d4", int.Parse(textBoxogrt_sifre.Text));
            cmd.Parameters.AddWithValue("@d5", textBoxkontenjan.Text);
            cmd.Parameters.AddWithValue("@d6", textBoxsicilno.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Öğretmen Güncellendi");


            sTUDENTDB.closeConnection();




        }

        private void ogrekle_button_Click(object sender, EventArgs e)
        {
            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into ogretmen(sicil_no,ogretmen_ad,ogretmen_soyad,ilgi_alani,kontenjan_bilgisi,ogretmen_password) values(@d1,@d2,@d3,@d4,@d5,@d6)", sTUDENTDB.getConnection);
            cmd.Parameters.AddWithValue("@d2", textBoxogrtisim.Text);
            cmd.Parameters.AddWithValue("@d3", textBoxogrtsoy.Text);
            cmd.Parameters.AddWithValue("@d4", textBoxilgialani.Text);
            cmd.Parameters.AddWithValue("@d5", textBoxkontenjan.Text);
            cmd.Parameters.AddWithValue("@d6", textBoxogrt_sifre.Text);
            cmd.Parameters.AddWithValue("@d1", textBoxsicilno.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Öğretmen Eklendi");
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu öğretmenin bilgilerini silmek istiyor musunuz?", "Delete Teacher", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                STUDENTDB sTUDENTDB = new STUDENTDB();
                sTUDENTDB.openConnection();
                NpgsqlCommand cmd1 = new NpgsqlCommand("delete from ogretmendersleri where okul_no = @d1 ", sTUDENTDB.getConnection);
                NpgsqlCommand cmd = new NpgsqlCommand("Delete from ogretmen where okul_no=@d1 ", sTUDENTDB.getConnection);

                cmd1.Parameters.AddWithValue("@d1", textBoxsicilno);
                cmd1.ExecuteNonQuery();
                cmd.Parameters.AddWithValue("@d1", textBoxsicilno);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Öğretmen Silindi.");



            }
        }
    }
}
