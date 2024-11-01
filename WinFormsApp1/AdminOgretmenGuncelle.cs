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
    public partial class AdminOgretmenGuncelle : Form
    {
        public AdminOgretmenGuncelle()
        {
            InitializeComponent();
        }

        private void ogretmen_data_DoubleClick(object sender, EventArgs e)
        {
            AdminOgretmenGuncelleDevam adminOgretmenGuncelleDevam = new AdminOgretmenGuncelleDevam();
            adminOgretmenGuncelleDevam.Show(this);

            adminOgretmenGuncelleDevam.textBoxsicilno.Text = ogretmen_data.CurrentRow.Cells[0].Value.ToString();
            adminOgretmenGuncelleDevam.textBoxogrtisim.Text = ogretmen_data.CurrentRow.Cells[1].Value.ToString();
            adminOgretmenGuncelleDevam.textBoxogrtsoy.Text = ogretmen_data.CurrentRow.Cells[2].Value.ToString();
            adminOgretmenGuncelleDevam.textBoxilgialani.Text = ogretmen_data.CurrentRow.Cells[3].Value.ToString();
            adminOgretmenGuncelleDevam.textBoxkontenjan.Text = ogretmen_data.CurrentRow.Cells[4].Value.ToString();
            adminOgretmenGuncelleDevam.textBoxogrt_sifre.Text = ogretmen_data.CurrentRow.Cells[5].Value.ToString();
        }

        private void ogretmen_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
