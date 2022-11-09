
namespace E_KartuMRTAdmin
{
    partial class FormMasterStasiun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kembaliKeMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSearchStasiun = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.tbidStasiun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStasiun = new System.Windows.Forms.DataGridView();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStasiun)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kembaliKeMenuToolStripMenuItem,
            this.masterTransaksiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 31);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kembaliKeMenuToolStripMenuItem
            // 
            this.kembaliKeMenuToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.kembaliKeMenuToolStripMenuItem.Name = "kembaliKeMenuToolStripMenuItem";
            this.kembaliKeMenuToolStripMenuItem.Size = new System.Drawing.Size(156, 27);
            this.kembaliKeMenuToolStripMenuItem.Text = "Kembali ke Menu";
            this.kembaliKeMenuToolStripMenuItem.Click += new System.EventHandler(this.kembaliKeMenuToolStripMenuItem_Click);
            // 
            // masterTransaksiToolStripMenuItem
            // 
            this.masterTransaksiToolStripMenuItem.Name = "masterTransaksiToolStripMenuItem";
            this.masterTransaksiToolStripMenuItem.Size = new System.Drawing.Size(14, 27);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(603, 43);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 24);
            this.label12.TabIndex = 119;
            this.label12.Text = "Search :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxSearchStasiun
            // 
            this.textBoxSearchStasiun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSearchStasiun.Location = new System.Drawing.Point(691, 43);
            this.textBoxSearchStasiun.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchStasiun.Name = "textBoxSearchStasiun";
            this.textBoxSearchStasiun.Size = new System.Drawing.Size(205, 28);
            this.textBoxSearchStasiun.TabIndex = 118;
            this.textBoxSearchStasiun.TextChanged += new System.EventHandler(this.textBoxSearchStasiun_TextChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClear.Location = new System.Drawing.Point(40, 321);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(125, 38);
            this.buttonClear.TabIndex = 117;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonUpdate.Location = new System.Drawing.Point(302, 321);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(125, 38);
            this.buttonUpdate.TabIndex = 116;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.AutoSize = true;
            this.buttonTambah.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonTambah.Location = new System.Drawing.Point(171, 321);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(125, 38);
            this.buttonTambah.TabIndex = 115;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(429, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 114;
            this.label3.Text = "Daftar Stasiun";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(45, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 111;
            this.label7.Text = "Status :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Maintenance",
            "Aktif",
            "Non-Aktif"});
            this.comboBoxStatus.Location = new System.Drawing.Point(123, 144);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(188, 30);
            this.comboBoxStatus.TabIndex = 110;
            // 
            // tbnama
            // 
            this.tbnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbnama.Location = new System.Drawing.Point(123, 108);
            this.tbnama.Margin = new System.Windows.Forms.Padding(4);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(303, 28);
            this.tbnama.TabIndex = 109;
            // 
            // tbidStasiun
            // 
            this.tbidStasiun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbidStasiun.Location = new System.Drawing.Point(123, 43);
            this.tbidStasiun.Margin = new System.Windows.Forms.Padding(4);
            this.tbidStasiun.Name = "tbidStasiun";
            this.tbidStasiun.ReadOnly = true;
            this.tbidStasiun.Size = new System.Drawing.Size(110, 28);
            this.tbidStasiun.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 107;
            this.label2.Text = "Nama :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 106;
            this.label1.Text = "ID Stasiun :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridViewStasiun
            // 
            this.dataGridViewStasiun.AllowUserToAddRows = false;
            this.dataGridViewStasiun.AllowUserToDeleteRows = false;
            this.dataGridViewStasiun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStasiun.Location = new System.Drawing.Point(433, 75);
            this.dataGridViewStasiun.Name = "dataGridViewStasiun";
            this.dataGridViewStasiun.ReadOnly = true;
            this.dataGridViewStasiun.RowHeadersVisible = false;
            this.dataGridViewStasiun.RowHeadersWidth = 51;
            this.dataGridViewStasiun.RowTemplate.Height = 24;
            this.dataGridViewStasiun.Size = new System.Drawing.Size(463, 284);
            this.dataGridViewStasiun.TabIndex = 105;
            this.dataGridViewStasiun.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStasiun_CellDoubleClick);
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxAlamat.Location = new System.Drawing.Point(123, 75);
            this.textBoxAlamat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(303, 28);
            this.textBoxAlamat.TabIndex = 121;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(38, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 120;
            this.label5.Text = "Alamat :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormMasterStasiun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 371);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxSearchStasiun);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.tbidStasiun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewStasiun);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMasterStasiun";
            this.Text = "Master Stasiun";
            this.Load += new System.EventHandler(this.FormMasterStasiun_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStasiun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kembaliKeMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterTransaksiToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSearchStasiun;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.TextBox tbidStasiun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewStasiun;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.Label label5;
    }
}