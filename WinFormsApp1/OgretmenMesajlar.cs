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
    public partial class OgretmenMesajlar : Form
    {
        public OgretmenMesajlar()
        {
            InitializeComponent();
        }

        private void OgretmenMesajlar_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter("select * from mesajlar where gönderen_no = @d1", sTUDENTDB.getConnection);
            adp.SelectCommand.Parameters.AddWithValue("@d1", ogr_PaylasilanDegerler.ogr_Username.ToString());
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Mesajlar");
            foreach (DataRow row in dataSet.Tables["Mesajlar"].Rows)
            {
                ListViewItem item = new ListViewItem(row["gönderen_no"].ToString());
                item.SubItems.Add(row["alici_no"].ToString());
                item.SubItems.Add(row["metin"].ToString());
                listView1.Items.Add(item);
                sTUDENTDB.closeConnection();



            }
            sTUDENTDB.openConnection();
            NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter("select * from mesajlar where alici_no= @d2", sTUDENTDB.getConnection);
            adp1.SelectCommand.Parameters.AddWithValue("@d2", ogr_PaylasilanDegerler.ogr_Username.ToString());
            DataSet dataSet1 = new DataSet();
            adp1.Fill(dataSet1, "Mesajlar");
            foreach (DataRow row in dataSet1.Tables["Mesajlar"].Rows)
            {
                ListViewItem item1 = new ListViewItem(row["gönderen_no"].ToString());
                item1.SubItems.Add(row["alici_no"].ToString());
                item1.SubItems.Add(row["metin"].ToString());
                listView1.Items.Add(item1);
                sTUDENTDB.closeConnection();



            }
            sTUDENTDB.openConnection();
            NpgsqlCommand command = new NpgsqlCommand("select * from ogrenci", sTUDENTDB.getConnection);
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            { list.Add(npgsqlDataReader["okul_no"].ToString()); }

            foreach (var deger in list)
            {
                comboBox1.Items.Add(deger.ToString());
            }
            sTUDENTDB.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            STUDENTDB sTUDENTDB = new STUDENTDB();
            sTUDENTDB.openConnection();
            NpgsqlCommand cmm = new NpgsqlCommand("insert into mesajlar (gönderen_no,alici_no,metin) values (@s1,@s2,@s3)", sTUDENTDB.getConnection);
            cmm.Parameters.AddWithValue("@s1", ogr_PaylasilanDegerler.ogr_Username.ToString());
            cmm.Parameters.AddWithValue("@s2", comboBox1.Text.ToString());
            cmm.Parameters.AddWithValue("@s3", textBox1.Text.ToString());
            cmm.ExecuteNonQuery();
            MessageBox.Show("Mesaj Gönderildi");
            sTUDENTDB.closeConnection();
        }
    }
}
