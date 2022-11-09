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

namespace E_KartuMRTAdmin
{
    public partial class FormMasterStasiun : Form
    {
        DataTable stasiun;
        int idxStasiun = -1;
        public FormMasterStasiun()
        {
            InitializeComponent();
        }

        private void kembaliKeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMasterStasiun_Load(object sender, EventArgs e)
        {
            loadStasiun();
        }

        private void loadStasiun()
        {
            string query = "SELECT id_stasiun AS 'ID Stasiun', alamat AS 'Alamat', nama_stasiun AS 'Nama', CASE status_stasiun WHEN 0 THEN 'Maintenance' WHEN 1 THEN 'Aktif' ELSE 'Non-Aktif' END AS 'Status' FROM stasiun";
            if (textBoxSearchStasiun.Text != "")
            {
                query += " WHERE nama_stasiun LIKE '%" + textBoxSearchStasiun.Text + "%' OR alamat LIKE '%" + textBoxSearchStasiun.Text + "%'";
            }
            query += " order by 1";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Koneksi.getConn());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                stasiun = new DataTable();
                da.Fill(stasiun);
                dataGridViewStasiun.DataSource = null;
                dataGridViewStasiun.DataSource = stasiun;
                dataGridViewStasiun.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewStasiun.Columns[0].Width = 30;
                dataGridViewStasiun.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewStasiun.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewStasiun.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void textBoxSearchStasiun_TextChanged(object sender, EventArgs e)
        {
            loadStasiun();
        }

        private void dataGridViewStasiun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int idx = e.RowIndex;
                tbidStasiun.Text = dataGridViewStasiun.Rows[idx].Cells[0].Value.ToString();
                idxStasiun = int.Parse(dataGridViewStasiun.Rows[idx].Cells[0].Value.ToString());
                textBoxAlamat.Text = dataGridViewStasiun.Rows[idx].Cells[1].Value.ToString();
                tbnama.Text = dataGridViewStasiun.Rows[idx].Cells[2].Value.ToString();
                comboBoxStatus.SelectedItem = dataGridViewStasiun.Rows[idx].Cells[3].Value.ToString();
                updateButtons();
            }
        }

        public void updateButtons()
        {
            if (idxStasiun > -1)
            {
                buttonTambah.Enabled = false;
                buttonUpdate.Enabled = true;
            }
            else
            {
                buttonTambah.Enabled = true;
                buttonUpdate.Enabled = false;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearStasiun();
        }

        public void clearStasiun()
        {
            idxStasiun = -1;
            tbidStasiun.Text = "";
            tbnama.Text = "";
            textBoxAlamat.Text = "";
            comboBoxStatus.SelectedIndex = -1;
            updateButtons();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (tbidStasiun.Text == "" && tbnama.Text != "" && textBoxAlamat.Text != "" && comboBoxStatus.SelectedIndex > -1)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Koneksi.getConn();
                    cmd.CommandText = "SELECT (MAX(id_stasiun)+1) FROM stasiun";
                    int idstasiun = int.Parse(cmd.ExecuteScalar().ToString());
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO stasiun VALUES(@idstasiun, @alamat, @nama, @status)";
                    cmd.Parameters.Add(new MySqlParameter("@idstasiun", idstasiun));
                    cmd.Parameters.Add(new MySqlParameter("@alamat", textBoxAlamat.Text.ToString()));
                    cmd.Parameters.Add(new MySqlParameter("@nama", tbnama.Text.ToString()));
                    cmd.Parameters.Add(new MySqlParameter("@status", comboBoxStatus.SelectedIndex));
                    cmd.ExecuteNonQuery();
                    clearStasiun();
                    textBoxSearchStasiun.Text = "";
                    loadStasiun();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Masukkan input!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (tbidStasiun.Text != "" && tbnama.Text != "" && textBoxAlamat.Text != "" && comboBoxStatus.SelectedIndex > -1)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Koneksi.getConn();
                    int idstasiun = idxStasiun;
                    cmd.CommandText = "UPDATE stasiun SET alamat = @alamat, nama_stasiun = @nama, status_stasiun = @status WHERE id_stasiun = @idstasiun";
                    cmd.Parameters.Add(new MySqlParameter("@idstasiun", idstasiun));
                    cmd.Parameters.Add(new MySqlParameter("@alamat", textBoxAlamat.Text.ToString()));
                    cmd.Parameters.Add(new MySqlParameter("@nama", tbnama.Text.ToString()));
                    cmd.Parameters.Add(new MySqlParameter("@status", comboBoxStatus.SelectedIndex));
                    cmd.ExecuteNonQuery();
                    clearStasiun();
                    textBoxSearchStasiun.Text = "";
                    loadStasiun();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Masukkan input!");
            }
        }
    }
}
