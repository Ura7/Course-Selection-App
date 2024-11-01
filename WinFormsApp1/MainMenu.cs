using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgrenciSistem obs = new OgrenciSistem();
            obs.Show(this);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            OgretmenSistem ogretmenSistem = new OgretmenSistem();
            ogretmenSistem.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminSistem adminSistem = new AdminSistem();
            adminSistem.Show(this);
        }
    }
}
