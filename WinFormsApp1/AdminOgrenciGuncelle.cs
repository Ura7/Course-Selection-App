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
    public partial class AdminOgrenciGuncelle : Form
    {
        public AdminOgrenciGuncelle()
        {
            InitializeComponent();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
            AdminOgrenciguncelleDevam adminOgrenciguncelleDevam = new AdminOgrenciguncelleDevam();
            adminOgrenciguncelleDevam.Show(this);

            adminOgrenciguncelleDevam.textBoxNO.Text = adminogr_data.CurrentRow.Cells[0].Value.ToString();
            adminOgrenciguncelleDevam.textBoxisim.Text = adminogr_data.CurrentRow.Cells[1].Value.ToString();
            adminOgrenciguncelleDevam.textBoxsoyisim.Text = adminogr_data.CurrentRow.Cells[2].Value.ToString();
            adminOgrenciguncelleDevam.textBoxdurum.Text = adminogr_data.CurrentRow.Cells[3].Value.ToString();
            adminOgrenciguncelleDevam.textBoxsifre.Text = adminogr_data.CurrentRow.Cells[4].Value.ToString();
            adminOgrenciguncelleDevam.textBoxilgi.Text = adminogr_data.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
