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
using WasteNoMoreUI.Models;

namespace WasteNoMoreUI
{
    public partial class FormPenggunaAdmin1 : Form
    {
        private DataGridViewRow r;
        public FormPenggunaAdmin1()
        {
            InitializeComponent();
            LoadUsersInfo();
        }

        private void LoadUsersInfo()
        {
            try
            {
                string query = "SELECT id_pengguna, nama_pengguna, username_pengguna, email_pengguna FROM pengguna;";
                DataTable dt = DatabaseManager.ExecuteQuery(query);

                dgvUsers.DataSource = dt;
                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris user yang akan dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Get the selected user's ID
            int selectedId = Convert.ToInt32(r.Cells["id_pengguna"].Value);

            // Confirmation dialog
            var confirmResult = MessageBox.Show(
                 "Are you sure you want to delete this user?",
                 "Confirm Delete",
                 MessageBoxButtons.YesNo);

             if (confirmResult == DialogResult.Yes)
             {
                 DeleteUserFromDatabase(selectedId);
                 LoadUsersInfo();
             }
        }

        private void DeleteUserFromDatabase(int userId)
        {
            try
            {
                string deleteQuery = "DELETE FROM pengguna WHERE id_pengguna = @id;";

                List<NpgsqlParameter> parameters = new List<NpgsqlParameter>
                {
                new NpgsqlParameter("@id",userId)
                };

                DatabaseManager.ExecuteNonQueryWithParams(deleteQuery, parameters);

                MessageBox.Show("User Succesfully deleted", "Succesful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvUsers.Rows[e.RowIndex];
            }
        }

    }
}
