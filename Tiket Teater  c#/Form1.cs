using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiket_Teater__c_
{
    public partial class Form1 : Form
    {
        private int transaksiCount = 0;
        private MySqlConnection connection;
        private MySqlConnection conn;
        public Form1()

        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
            InitializeDatabaseConnection();
            DGV1.CellClick += DGV1_CellClick;
            btndelet.Click += new EventHandler(this.btndelet_Click);
            btncari.Click += new EventHandler(this.btncari_Click);

        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "Server=localhost;Database=teater;Uid=root;";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Koneksi ke database berhasil!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbjenis.Items.Add("Tiket VVIP");
            cmbjenis.Items.Add("Tiket VIP");
            cmbjenis.Items.Add("Tiket Biasa");
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            string query = "SELECT * FROM transaksi";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();

            try
            {
                adapter.Fill(dataTable);
                DGV1.DataSource = dataTable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Gagal memuat data dari database: " + ex.Message);
            }
        }

        private void cmbjenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbjenis.SelectedItem != null)
            {
                if (cmbjenis.SelectedItem.ToString() == "Tiket VVIP")
                {
                    txharga.Text = "50000";
                }
                else if (cmbjenis.SelectedItem.ToString() == "Tiket VIP")
                {
                    txharga.Text = "45000";
                }
                else if (cmbjenis.SelectedItem.ToString() == "Tiket Biasa")
                {
                    txharga.Text = "25000";
                }
            }
        }

        private void txharga_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }
        private void CalculateTotal()
        {
            if (int.TryParse(txjumlah.Text, out int jumlah) && int.TryParse(txharga.Text, out int harga))
            {
                int total = jumlah * harga;
                txttotal.Text = total.ToString();
            }
            else
            {
                txttotal.Text = "0";
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            try
            {
                // Dapatkan ID transaksi terakhir dan tambah 1
                int lastId = GetLastTransactionId();
                transaksiCount = lastId + 1;
                txtidtransaksi.Text = "TR" + transaksiCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mendapatkan ID transaksi: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private int GetLastTransactionId()
        {
            int lastId = 0;
            string query = "SELECT MAX(CAST(SUBSTRING(idtransaksi, 3) AS UNSIGNED)) FROM transaksi";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    lastId = Convert.ToInt32(result);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Gagal mengambil ID transaksi terakhir: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return lastId;
        }

        private void ClearForm()
        {
            txtidtransaksi.Clear();
            txnama.Clear();
            txjumlah.Clear();
            cmbjenis.SelectedIndex = -1;
            txharga.Clear();
            txttotal.Clear();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            // Contoh query untuk menyimpan data ke database
            string query = "INSERT INTO transaksi (idtransaksi, nama, jumlah, jenis, harga, total) VALUES (@idtransaksi, @nama, @jumlah, @jenis, @harga, @total)";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@idtransaksi", txtidtransaksi.Text);
            cmd.Parameters.AddWithValue("@nama", txnama.Text);
            cmd.Parameters.AddWithValue("@jumlah", txjumlah.Text);
            cmd.Parameters.AddWithValue("@jenis", cmbjenis.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@harga", txharga.Text);
            cmd.Parameters.AddWithValue("@total", txttotal.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan!");
                LoadDataGrid(); // Memuat ulang data setelah data disimpan
                ClearForm();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidtransaksi.Text))
            {
                return;
            }

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            string query = "UPDATE transaksi SET nama = @nama, jumlah = @jumlah, jenis = @jenis, harga = @harga, total = @total WHERE idtransaksi = @idtransaksi";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@idtransaksi", txtidtransaksi.Text);
            cmd.Parameters.AddWithValue("@nama", txnama.Text);
            cmd.Parameters.AddWithValue("@jumlah", txjumlah.Text);
            cmd.Parameters.AddWithValue("@jenis", cmbjenis.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@harga", txharga.Text);
            cmd.Parameters.AddWithValue("@total", txttotal.Text);

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data berhasil diperbarui!");
                    LoadDataGrid(); // Refresh data di DataGridView setelah update
                    ClearForm(); // Kosongkan form setelah update
                }
                else
                {
                    MessageBox.Show("Tidak ada data yang diperbarui.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Gagal memperbarui data: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV1.Rows[e.RowIndex];

                txtidtransaksi.Text = row.Cells["idtransaksi"].Value.ToString();
                txnama.Text = row.Cells["nama"].Value.ToString();
                txjumlah.Text = row.Cells["jumlah"].Value.ToString();
                cmbjenis.SelectedItem = row.Cells["jenis"].Value.ToString();
                txharga.Text = row.Cells["harga"].Value.ToString();
                txttotal.Text = row.Cells["total"].Value.ToString();
            }
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidtransaksi.Text))
            {
                return;
            }

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            string query = "DELETE FROM transaksi WHERE idtransaksi = @idtransaksi";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@idtransaksi", txtidtransaksi.Text);

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data berhasil dihapus!");
                    LoadDataGrid(); // Refresh data di DataGridView setelah delete
                    ClearForm(); // Kosongkan form setelah delete
                }
                else
                {
                    MessageBox.Show("Tidak ada data yang dihapus.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            string query = "SELECT * FROM transaksi WHERE nama LIKE @nama OR idtransaksi LIKE @idtransaksi";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@nama", "%" + txtcari.Text + "%");
            cmd.Parameters.AddWithValue("@idtransaksi", "%" + txtcari.Text + "%");

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DGV1.DataSource = dataTable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Gagal mencari data: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {

        }

        private void txjumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void txnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidtransaksi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
