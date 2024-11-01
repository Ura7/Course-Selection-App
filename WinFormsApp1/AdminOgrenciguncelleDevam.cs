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
    public partial class AdminOgrenciguncelleDevam : Form
    {
        public AdminOgrenciguncelleDevam()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guncelle_button_Click(object sender, EventArgs e)
        {
            STUDENTDB sTUDENTDB = new STUDENTDB();


            sTUDENTDB.openConnection();
            NpgsqlCommand cmd = new NpgsqlCommand("update ogrenci set ogr_isim=@d1, ogr_soyad=@d2, durum=@d3, ogr_password=@d4, ogr_ilgialani=@d5 where okul_no = @d6", sTUDENTDB.getConnection);
            cmd.Parameters.AddWithValue("@d1", textBoxisim.Text);
            cmd.Parameters.AddWithValue("@d2", textBoxsoyisim.Text);
            cmd.Parameters.AddWithValue("@d3", textBoxdurum.Text);
            cmd.Parameters.AddWithValue("@d4", textBoxsifre.Text);
            cmd.Parameters.AddWithValue("@d5", textBoxilgi.Text);
            cmd.Parameters.AddWithValue("@d6", textBoxNO.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ogrenci Güncellendi");


            sTUDENTDB.closeConnection();


        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int ogrno = Convert.ToInt32(textBoxNO.Text);

            if (MessageBox.Show("Bu öğrencinin bilgilerini silmek istiyor musunuz?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                STUDENTDB sTUDENTDB = new STUDENTDB();
                sTUDENTDB.openConnection();
                NpgsqlCommand cmd1 = new NpgsqlCommand("delete from ogrencidersleri where okul_no = @d1 ", sTUDENTDB.getConnection);
                NpgsqlCommand cmd = new NpgsqlCommand("Delete from ogrenci where okul_no=@d1 ", sTUDENTDB.getConnection);

                cmd1.Parameters.AddWithValue("@d1", textBoxNO.Text);
                cmd1.ExecuteNonQuery();
                cmd.Parameters.AddWithValue("@d1", textBoxNO.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Öğrenci Silindi.");



            }
        }

        private void ogrekle_button_Click(object sender, EventArgs e)
        {
            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into ogrenci(okul_no,ogr_isim,ogr_soyad,durum,ogr_password,ogr_ilgialani) values(@d1,@d2,@d3,@d4,@d5,@d6)", sTUDENTDB.getConnection);
            cmd.Parameters.AddWithValue("d1", textBoxNO.Text);
            cmd.Parameters.AddWithValue("d2", textBoxisim.Text);
            cmd.Parameters.AddWithValue("d3", textBoxsoyisim.Text);
            cmd.Parameters.AddWithValue("d4", textBoxdurum.Text);
            cmd.Parameters.AddWithValue("d5", textBoxsifre.Text);
            cmd.Parameters.AddWithValue("d6", textBoxilgi.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Eklendi");
        }

        private void AdminOgrenciguncelleDevam_Load(object sender, EventArgs e)
        {

        }
    }
}
