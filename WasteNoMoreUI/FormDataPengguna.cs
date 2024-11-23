using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Import class
using WasteNoMoreUI.Models;

namespace WasteNoMoreUI
{
    public partial class FormDataPengguna : Form
    {
        int currentId = -1;
        public FormDataPengguna(int currentId)
        {
            InitializeComponent();
            this.currentId = currentId;
            LoadUserInfo();
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int currentId = this.currentId;
            string updateQuery = @"
            PDATE pengguna
            SET 
            nama_pengguna = COALESCE(@NamaPengguna, nama_pengguna),
            username_pengguna = COALESCE(@UsernamePengguna, username_pengguna),
            email_pengguna = COALESCE(@EmailPengguna, email_pengguna)
            WHERE id_pengguna = @IdPengguna;
            ";

            List<NpgsqlParameter> parameters = new List<NpgsqlParameter>
            {
                new NpgsqlParameter("@IdPengguna", currentId),
                new NpgsqlParameter("@NamaPengguna", tbNama.Text),
                new NpgsqlParameter("@UsernamePengguna", tbUsername.Text),
                new NpgsqlParameter("@EmailPengguna", tbEmail.Text)
             };

            try
            {
                //jika entri sampah berhasil dimasukkan
                DatabaseManager.ExecuteNonQueryWithParams(updateQuery, parameters);
                LoadUserInfo();
                MessageBox.Show("Data berhasil diupdate");
            }
            catch (Exception ex)
            {
                //setelah disimpan, kosongkan input
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserInfo()
        {
            string currentId = this.currentId.ToString();
            string query = $"SELECT nama_pengguna, username_pengguna, password_pengguna, email_pengguna FROM pengguna WHERE id_pengguna = {currentId}";

            DataTable dt = DatabaseManager.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                var pengguna = new Pengguna(
                    Convert.ToInt32(currentId),
                    row["nama_pengguna"].ToString(),
                    row["email_pengguna"].ToString(),
                    row["username_pengguna"].ToString(),
                    row["password_pengguna"].ToString()
                );

                lblNama.Text = pengguna.NamaPengguna;
                lblEmail.Text = pengguna.Email;
                lblUsername.Text = pengguna.Username;
            }

            
        }

    }
}
