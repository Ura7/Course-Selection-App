using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using SautinSoft;
using System.Diagnostics.Metrics;

namespace WinFormsApp1
{
    public partial class Transkript_yukle : Form
    {
        public Transkript_yukle()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "PDF Dosyaları|*.pdf;*.PDF|Tüm Dosyalar|*.*";
            if (opf.ShowDialog()== DialogResult.OK)
            {
                string pdfFilepath = opf.FileName;
                SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
                f.OpenPdf(pdfFilepath);

                if(f.PageCount>0) {

                    f.ImageOptions.Dpi = 300;
                   f.ToMultipageTiff(@"C:\Users\Acer\Desktop\Transkript_Donustur\result.tiff");
                }
                string a = "C:\\Users\\Acer\\Desktop\\Transkript_Donustur\\result.tiff";


                string ocrText = POCR(a);

                if(!string.IsNullOrWhiteSpace(ocrText)) 
                {
                    InsertData(ocrText);
                
                }

            }
        }

        public string POCR(string pdfFilepath)
        {

          

                        using (var engine = new TesseractEngine("C:/Users/Acer/source/repos/WinFormsApp1/WinFormsApp1/bin/Debug/net6.0-windows/tessdata", "tur", EngineMode.Default))
            {
                using (var img =Pix.LoadFromFile(pdfFilepath))
                {
                    using (var page =engine.Process(img))
                    {
                        return page.GetText();
                    }
                }




            }
        }

        private void InsertData(string ocrText)
        {
            string connString = "server=localhost; port=5432; Database=Ogrenciler; user ID= postgres; password=2149";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string cikar = "PDF Focus .Net 2023.5.10.0 trial. Have questions? Email us: support@sautinsoft.com";

                int baslangicIndex = ocrText.IndexOf(cikar);
                if (baslangicIndex >= 0)
                {
                    
                    int bitisIndex = baslangicIndex + cikar.Length;

                    
                    string cikartilanCumle = ocrText.Substring(baslangicIndex, bitisIndex - baslangicIndex);
                    string geriyeKalanMetin = ocrText.Remove(baslangicIndex, bitisIndex - baslangicIndex);
                    ocrText = geriyeKalanMetin;

                }


                    string[] parcalar = ocrText.Split('/');
                
                int azal = parcalar.Length-6;
                int art = 5;
                while (azal >0)
                {
                    using (var cmd = new NpgsqlCommand("INSERT INTO ogrencidersleri (okul_no, dersid, akts, dersnot, dersismi) VALUES (@okul_no, @dersid, @akts, @dersnot, @dersismi)", conn))
                   {
                      

                        cmd.Parameters.AddWithValue("okul_no", parcalar[art].Trim());
                        cmd.Parameters.AddWithValue("dersid", int.Parse(parcalar[art+1].Trim()));
                        cmd.Parameters.AddWithValue("akts", int.Parse(parcalar[art+2].Trim()));
                        cmd.Parameters.AddWithValue("dersnot", parcalar[art+3].Trim());
                        cmd.Parameters.AddWithValue("dersismi", parcalar[art+4].Trim());
                        cmd.ExecuteNonQuery();
                        azal = azal-5;
                        art = art + 5;
                    }



                }
                
                

                conn.Close();
            }

        }
    }
}
