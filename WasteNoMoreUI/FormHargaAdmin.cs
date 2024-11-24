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
    public partial class FormHargaAdmin : Form
    {
        private DataTable dt;
        private DataGridViewRow r;
        private FormDashobardAdmin formDashobardAdmin;
        public FormHargaAdmin(FormDashobardAdmin formDashobardAdmin)
        {
            InitializeComponent();
            this.formDashobardAdmin = formDashobardAdmin;
        }

        private void FormHargaAdmin_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            LoadDataHarga();
        }

        private void LoadComboBoxData()
        {
            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();

                    // Load data aplikasi ke ComboBox hanya yang is_deleted = false
                    var cmdAplikasi = new NpgsqlCommand("SELECT id_aplikasi, nama_aplikasi FROM aplikasi WHERE is_deleted = false;", conn);
                    var adapterAplikasi = new NpgsqlDataAdapter(cmdAplikasi);
                    var dtAplikasi = new DataTable();
                    adapterAplikasi.Fill(dtAplikasi);

                    cmbAplikasi.DataSource = dtAplikasi;
                    cmbAplikasi.DisplayMember = "nama_aplikasi";
                    cmbAplikasi.ValueMember = "id_aplikasi";

                    // Load data kategori ke ComboBox hanya yang is_deleted = false
                    var cmdKategori = new NpgsqlCommand("SELECT id_kategori, nama_kategori FROM kategori WHERE is_deleted = false;", conn);
                    var adapterKategori = new NpgsqlDataAdapter(cmdKategori);
                    var dtKategori = new DataTable();
                    adapterKategori.Fill(dtKategori);

                    cmbKategori.DataSource = dtKategori;
                    cmbKategori.DisplayMember = "nama_kategori";
                    cmbKategori.ValueMember = "id_kategori";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load ComboBox Data FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataHarga()
        {
            try
            {
                string query = @"
            SELECT h.id_harga, a.nama_aplikasi, k.nama_kategori, h.harga
            FROM harga h
            JOIN aplikasi a ON h.id_aplikasi = a.id_aplikasi
            JOIN kategori k ON h.id_kategori = k.id_kategori
            WHERE a.is_deleted = false AND k.is_deleted = false;";  // Menambahkan filter is_deleted = false pada aplikasi dan kategori

                dt = DatabaseManager.ExecuteQuery(query);
                dgvHarga.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load Data FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAplikasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbInsertHarga_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT add_harga(@id_aplikasi, @id_kategori, @harga);", conn))
                    {
                        cmd.Parameters.AddWithValue("id_aplikasi", cmbAplikasi.SelectedValue);
                        cmd.Parameters.AddWithValue("id_kategori", cmbKategori.SelectedValue);
                        cmd.Parameters.AddWithValue("harga", Convert.ToDecimal(txtHarga.Text));

                        bool result = (bool)cmd.ExecuteScalar();

                        if (result)
                        {
                            MessageBox.Show("Harga berhasil ditambahkan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataHarga();
                            txtHarga.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Harga gagal ditambahkan! Kombinasi aplikasi dan kategori mungkin sudah ada.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbUpdateHarga_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris data yang akan diperbarui", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT update_harga(@id_harga, @harga);", conn))
                    {
                        cmd.Parameters.AddWithValue("id_harga", Convert.ToInt32(r.Cells["id_harga"].Value));
                        cmd.Parameters.AddWithValue("harga", Convert.ToDecimal(txtHarga.Text));

                        bool result = (bool)cmd.ExecuteScalar();

                        if (result)
                        {
                            MessageBox.Show("Harga berhasil diperbarui!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataHarga();
                            txtHarga.Clear();
                            r = null;
                        }
                        else
                        {
                            MessageBox.Show("Pembaruan harga gagal! Pastikan data valid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbDeleteHarga_Click(object sender, EventArgs e)
        {
            {
                if (r == null)
                {
                    MessageBox.Show("Pilih baris data yang akan dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus harga ini?", "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int idHarga = Convert.ToInt32(r.Cells["id_harga"].Value);

                        using (var conn = DatabaseManager.GetConnection())
                        {
                            conn.Open();
                            using (var cmd = new NpgsqlCommand("DELETE FROM harga WHERE id_harga = @id_harga;", conn))
                            {
                                cmd.Parameters.AddWithValue("id_harga", idHarga);

                                int deleteResult = cmd.ExecuteNonQuery();

                                if (deleteResult > 0)
                                {
                                    MessageBox.Show("Harga berhasil dihapus!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadDataHarga();
                                    txtHarga.Clear();
                                    r = null;
                                }
                                else
                                {
                                    MessageBox.Show("Harga tidak ditemukan atau sudah dihapus.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Delete FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLoadHarga_Click(object sender, EventArgs e)
        {
            LoadDataHarga();
        }

        private void btnBackHarga_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void dgvHarga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvHarga.Rows[e.RowIndex];
                cmbAplikasi.Text = r.Cells["nama_aplikasi"].Value.ToString();
                cmbKategori.Text = r.Cells["nama_kategori"].Value.ToString();
                txtHarga.Text = r.Cells["harga"].Value.ToString();
            }
        }

        private void FormHargaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            formDashobardAdmin.Show();
        }
    }
}
