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
    public partial class Ogretmenilgialani : Form
    {
        public Ogretmenilgialani()
        {
            InitializeComponent();
        }

        private void iglialaniekle_button_Click(object sender, EventArgs e)
        {
            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();
            NpgsqlCommand cmd = new NpgsqlCommand("update ogretmen set ilgi_alani=@d1 where sicil_no = @d2", sTUDENTDB.getConnection);
            cmd.Parameters.AddWithValue("@d1", ilgialani_textBox.Text);
            cmd.Parameters.AddWithValue("@d2", ogr_PaylasilanDegerler.ogr_Username);
            cmd.ExecuteNonQuery();
            MessageBox.Show("İlgi alani basariyla eklendi! ");
            
            
            sTUDENTDB.closeConnection();    

        }
    }
}
