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
    public partial class FormMasterKereta : Form
    {
        DataTable kereta, rute;
        int idxKereta = -1;
        public FormMasterKereta()
        {
            InitializeComponent();
        }

        private void kembaliKeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMasterKereta_Load(object sender, EventArgs e)
        {
            loadKereta();
            loadRute();
        }

        private void textBoxSearchKereta_TextChanged(object sender, EventArgs e)
        {
            loadKereta();
        }

        private void loadKereta()
        {
            string query = "SELECT k.id_kereta AS 'ID Rute', r.id_rute, r.nama_rute AS 'Nama Rute', k.nama_kereta AS 'Nama Kereta', k.gerbong AS 'gerbong', CASE k.status_kereta WHEN 0 THEN 'Maintenance' WHEN 1 THEN 'Aktif' ELSE 'Non-Aktif' END AS 'Status' FROM kereta k, rute r WHERE k.id_rute = r.id_rute";
            if (textBoxSearchKereta.Text != "")
            {
                query += " WHERE nama_kereta LIKE '%" + textBoxSearchKereta.Text + "%'";
            }
            query += " order by 1";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Koneksi.getConn());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                kereta = new DataTable();
                da.Fill(kereta);
                dataGridViewKereta.DataSource = null;
                dataGridViewKereta.DataSource = kereta;
                dataGridViewKereta.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewKereta.Columns[0].Width = 30;
                dataGridViewKereta.Columns[1].Visible = false;
                dataGridViewKereta.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewKereta.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewKereta.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewKereta.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void dataGridViewKereta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int idx = e.RowIndex;
                tbidKereta.Text = dataGridViewKereta.Rows[idx].Cells[0].Value.ToString();
                idxKereta = int.Parse(dataGridViewKereta.Rows[idx].Cells[0].Value.ToString());
                comboBoxRute.SelectedValue = int.Parse(dataGridViewKereta.Rows[idx].Cells[1].Value.ToString());
                tbnama.Text = dataGridViewKereta.Rows[idx].Cells[3].Value.ToString();
                nudGerbong.Value = int.Parse(dataGridViewKereta.Rows[idx].Cells[4].Value.ToString());
                comboBoxStatus.SelectedItem = dataGridViewKereta.Rows[idx].Cells[5].Value.ToString();
                updateButtons();
            }
        }

        public void updateButtons()
        {
            if (idxKereta > -1)
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
            clearKereta();
        }

        public void clearKereta()
        {
            idxKereta = -1;
            tbidKereta.Text = "";
            tbnama.Text = "";
            nudGerbong.Value = 0;
            comboBoxStatus.SelectedIndex = -1;
            comboBoxRute.SelectedIndex = 0;
            updateButtons();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (tbidKereta.Text == "" && tbnama.Text != "" && comboBoxStatus.SelectedIndex > -1 && comboBoxRute.SelectedIndex > -1 && nudGerbong.Value > 0)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Koneksi.getConn();
                    cmd.CommandText = "SELECT (MAX(id_kereta)+1) FROM kereta";
                    int idkereta = int.Parse(cmd.ExecuteScalar().ToString());
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO kereta VALUES(@idkereta, @idrute, @nama, @gerbong, @status)";
                    cmd.Parameters.Add(new MySqlParameter("@idkereta", idkereta));
                    cmd.Parameters.Add(new MySqlParameter("@idrute", int.Parse(comboBoxRute.SelectedValue.ToString())));
                    cmd.Parameters.Add(new MySqlParameter("@nama", tbnama.Text.ToString()));
                    cmd.Parameters.Add(new MySqlParameter("@gerbong", int.Parse(nudGerbong.Value.ToString())));
                    cmd.Parameters.Add(new MySqlParameter("@status", comboBoxStatus.SelectedIndex));
                    cmd.ExecuteNonQuery();
                    clearKereta();
                    textBoxSearchKereta.Text = "";
                    loadKereta();
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
            if (tbidKereta.Text != "" && tbnama.Text != "" && comboBoxStatus.SelectedIndex > -1 && comboBoxRute.SelectedIndex > -1 && nudGerbong.Value > 0)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Koneksi.getConn();
                    int idkereta = int.Parse(tbidKereta.Text);
                    cmd.CommandText = "UPDATE kereta SET id_rute = @idrute, nama_kereta = @nama, gerbong = @gerbong, status_kereta = @status WHERE id_kereta = @idkereta";
                    cmd.Parameters.Add(new MySqlParameter("@idkereta", idkereta));
                    cmd.Parameters.Add(new MySqlParameter("@idrute", int.Parse(comboBoxRute.SelectedValue.ToString())));
                    cmd.Parameters.Add(new MySqlParameter("@nama", tbnama.Text.ToString()));
                    cmd.Parameters.Add(new MySqlParameter("@gerbong", int.Parse(nudGerbong.Value.ToString())));
                    cmd.Parameters.Add(new MySqlParameter("@status", comboBoxStatus.SelectedIndex));
                    cmd.ExecuteNonQuery();
                    clearKereta();
                    textBoxSearchKereta.Text = "";
                    loadKereta();
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

        public void loadRute()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_rute AS 'member', nama_rute AS 'display' FROM rute WHERE status_rute != 2", Koneksi.getConn());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxRute.DataSource = null;
                comboBoxRute.DataSource = dt;
                comboBoxRute.DisplayMember = "display";
                comboBoxRute.ValueMember = "member";
                comboBoxRute.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Gagal Load Category!");
            }

        }
    }
}
