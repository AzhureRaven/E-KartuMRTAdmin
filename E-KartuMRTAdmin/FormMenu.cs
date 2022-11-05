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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void masterRuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterRute frm = new FormMasterRute();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void masterStasiunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterStasiun frm = new FormMasterStasiun();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void masterKeretaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterKereta frm = new FormMasterKereta();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
