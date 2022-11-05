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
    public partial class FormMasterRute : Form
    {
        DataTable rute, stasiun, drute;
        int idxRute = -1;
        public FormMasterRute()
        {
            InitializeComponent();
        }

        private void loadRute()
        {
            string query = "SELECT id_rute AS 'ID Rute', nama_rute AS 'Nama', ppm AS 'PPM', CASE status_rute WHEN 0 THEN 'Maintenance' WHEN 1 THEN 'Aktif' ELSE 'Non-Aktif' END AS 'Status' FROM rute";
            if(textBoxSearchRute.Text != "")
            {
                query += " WHERE nama_rute LIKE '%" + textBoxSearchRute.Text + "%'";
            }
            query += " order by 1";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Koneksi.getConn());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                rute = new DataTable();
                da.Fill(rute);
                dataGridViewRute.DataSource = null;
                dataGridViewRute.DataSource = rute;
                dataGridViewRute.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewRute.Columns[0].Width = 30;
                dataGridViewRute.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewRute.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewRute.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void loadStasiun()
        {
            string query = "SELECT id_stasiun AS 'ID Stasiun', nama_stasiun AS 'Nama', alamat AS 'Alamat' FROM stasiun WHERE status_stasiun != 2";
            if (textBoxSearchStasiun.Text != "")
            {
                query += " AND nama_stasiun LIKE '%" + textBoxSearchStasiun.Text + "%'";
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
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void FormMasterRute_Load(object sender, EventArgs e)
        {
            loadRute();
            loadStasiun();
        }

        private void textBoxSearchRute_TextChanged(object sender, EventArgs e)
        {
            loadRute();
        }

        private void textBoxSearchStasiun_TextChanged(object sender, EventArgs e)
        {
            loadStasiun();
        }

        private void dataGridViewRute_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int idx = e.RowIndex;
                tbidrute.Text = dataGridViewRute.Rows[idx].Cells[0].Value.ToString();
                idxRute = int.Parse(dataGridViewRute.Rows[idx].Cells[0].Value.ToString());
                tbnama.Text = dataGridViewRute.Rows[idx].Cells[1].Value.ToString();
                string ppm = dataGridViewRute.Rows[idx].Cells[2].Value.ToString();
                ppm = ppm.Substring(0, ppm.IndexOf('.', 0));
                nUPPPM.Value = int.Parse(ppm);
                comboBoxStatus.SelectedItem = dataGridViewRute.Rows[idx].Cells[3].Value.ToString();
                updateButtons();

                string query = "SELECT dr.stasiun_ke, dr.id_stasiun, st.nama_stasiun, dr.jarak_next FROM drute dr, stasiun st WHERE dr.id_stasiun = st.id_stasiun AND dr.id_rute = "+tbidrute.Text+" ORDER BY 1";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, Koneksi.getConn());
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    drute = new DataTable();
                    da.Fill(drute);
                    dataGridViewDRute.Rows.Clear();
                    for (int i = 0; i < drute.Rows.Count; i++)
                    {
                        dataGridViewDRute.Rows.Add(drute.Rows[i][0].ToString(), drute.Rows[i][1].ToString(), drute.Rows[i][2].ToString(), drute.Rows[i][3].ToString());
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
        }

        public void updateButtons()
        {
            if(idxRute > -1)
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
            idxRute = -1;
            tbidrute.Text = "";
            tbnama.Text = "";
            nUPPPM.Value = 0;
            comboBoxStatus.SelectedIndex = -1;
            dataGridViewDRute.Rows.Clear();
            updateButtons();
        }

        private void dataGridViewStasiun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int idx = e.RowIndex;
                textBoxIdStasiun.Text = dataGridViewStasiun.Rows[idx].Cells[0].Value.ToString();
                textBoxNamaStasiun.Text = dataGridViewStasiun.Rows[idx].Cells[1].Value.ToString();
                textBoxAlamat.Text = dataGridViewStasiun.Rows[idx].Cells[2].Value.ToString();
                buttonTambahStasiun.Enabled = true;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataGridViewDRute.Rows.Clear();
        }

        private void buttonTambahStasiun_Click(object sender, EventArgs e)
        {
            if(numericUpDownJarak.Value > 0)
            {
                bool nonKembar = true;
                foreach (DataGridViewRow dr in dataGridViewDRute.Rows)
                {
                    if(dr.Cells[1].Value.ToString() == textBoxIdStasiun.Text)
                    {
                        nonKembar = false;
                        break;
                    } 
                }
                if (nonKembar)
                {
                    dataGridViewDRute.Rows.Add(dataGridViewDRute.Rows.Count + 1, textBoxIdStasiun.Text, textBoxNamaStasiun.Text, numericUpDownJarak.Value.ToString());
                    clearDRute();
                }
                else
                {
                    MessageBox.Show("Stasiun Kembar");
                }
            }
            else
            {
                MessageBox.Show("Jarak Next harus > 0");
            }
            
        }

        private void buttonClearDRute_Click(object sender, EventArgs e)
        {
            clearDRute();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {

        }

        public void clearDRute()
        {
            textBoxIdStasiun.Text = "";
            textBoxNamaStasiun.Text = "";
            textBoxAlamat.Text = "";
            numericUpDownJarak.Value = 0;
            buttonTambahStasiun.Enabled = false;
        }

        private void kembaliKeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
