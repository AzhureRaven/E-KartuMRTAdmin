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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            Koneksi.openConn();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text != "" && textBoxPass.Text != "")
            {
                if(textBoxUser.Text == "admin" && textBoxPass.Text == "admin")
                {
                    FormMenu frm = new FormMenu();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Username/Password Salah!");
                }
            }
            else
            {
                MessageBox.Show("Isikan Username/Password");
            }
        }

        public void Clear()
        {
            textBoxPass.Text = "";
            textBoxUser.Text = "";
        }

    }
}
