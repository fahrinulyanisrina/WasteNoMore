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
        private static string ConnectionString = "Host=localhost;Username=postgres;Password=postgres;Database=WasteNoMore";

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

        //method utk mengeksekusi query SQL dgn parameter
        public static int ExecuteNonQueryWithParams(string query, List<NpgsqlParameter> parameters)
        {
            int result = 0;
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        //menambahkan parameter ke perintah
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }

                        //mengeksekusi query tanpa return data (misalnya untuk INSERT, UPDATE, DELETE)
                        result = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        //method utk mengeksekusi query SQL tanpa parameter
        public static object ExecuteScalarQuery(string query, List<NpgsqlParameter> parameters)
        {
            object result = null;
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        //menambahkan parameter ke perintah
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }

                        //mengeksekusi query dan return satu nilai
                        result = cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public static object ExecuteScalarQueryParams(string query, List<NpgsqlParameter> parameters)
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters.ToArray());
                    return command.ExecuteScalar();
                }
            }
        }

        // Tambahkan metode ExecuteQueryWithParams
        public static DataTable ExecuteQueryWithParams(string query, List<NpgsqlParameter> parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // Tambahkan parameter jika ada
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }

                        // Eksekusi query dan load hasilnya ke DataTable
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

    }


}