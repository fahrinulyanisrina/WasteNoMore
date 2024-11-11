using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//impor package
using Npgsql;

namespace WasteNoMoreUI.Models
{
    //membuat class DatabaseManager
    internal class DatabaseManager
    {
        //membuat variabel string koneksi 'ConnectionString'
        //properties db
        private static string ConnectionString = "Host=localhost;Username=postgres;Password=abc;Database=WasteNoMore";

        //method utk membuat koneksi
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(ConnectionString);
        }

        //method utk mengeksekusi query SQL dan return hasilnya dlm bntk Data Table
        public static DataTable ExecuteQuery(string query)
        {
            //object class DataTable --> dt
            DataTable dt = new DataTable();
            try
            {
                using (var conn = GetConnection())
                {
                    //membuka koneksi
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        //menyimpan hasil eksekusi ke object reader
                        using (var reader = cmd.ExecuteReader())
                        {
                            //load data tadi reader dan disimpan ke dt (Data Table)
                            dt.Load(reader);
                        }
                    }
                //menutup koneksi
                }
            }
            catch (Exception ex)
            {
                //agar program tidak berhenti langsung, menampilkan messagebox error
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}