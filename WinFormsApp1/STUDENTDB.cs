using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class STUDENTDB
    {


        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=Ogrenciler; user ID= postgres; password=2149");

        public NpgsqlConnection getConnection
        {
            get { return baglanti; }
        }

        public void openConnection()
        {
            if(baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


        }
        public void closeConnection()
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }


        }


    }
}
