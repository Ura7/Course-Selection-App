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
    public partial class AdminSistem : Form
    {
        public AdminSistem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            STUDENTDB studentDB = new STUDENTDB();
            string sorgu = "select * from admin where username= '" + textBox1.Text + "' and  password='" + textBox2.Text + "'";
            DataTable table = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu, studentDB.getConnection);
            adp.Fill(table);





            if (table.Rows.Count > 0)

            {
                this.DialogResult = DialogResult.OK;
                AdminSistemMenu admSys = new AdminSistemMenu();
                admSys.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("INVALID PASSWORD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
