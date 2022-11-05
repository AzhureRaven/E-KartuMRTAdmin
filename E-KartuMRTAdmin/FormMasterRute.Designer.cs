
namespace E_KartuMRTAdmin
{
    partial class FormMasterRute
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kembaliKeMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewRute = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.tbidrute = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nUPPPM = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewDRute = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewStasiun = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonTambahStasiun = new System.Windows.Forms.Button();
            this.numericUpDownJarak = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxIdStasiun = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNamaStasiun = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClearDRute = new System.Windows.Forms.Button();
            this.textBoxSearchRute = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSearchStasiun = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Stasiun_Ke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Stasiun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jarak_Next = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPPPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDRute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStasiun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJarak)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(906, 31);
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
            // dataGridViewRute
            // 
            this.dataGridViewRute.AllowUserToAddRows = false;
            this.dataGridViewRute.AllowUserToDeleteRows = false;
            this.dataGridViewRute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRute.Location = new System.Drawing.Point(430, 65);
            this.dataGridViewRute.Name = "dataGridViewRute";
            this.dataGridViewRute.ReadOnly = true;
            this.dataGridViewRute.RowHeadersVisible = false;
            this.dataGridViewRute.RowHeadersWidth = 51;
            this.dataGridViewRute.RowTemplate.Height = 24;
            this.dataGridViewRute.Size = new System.Drawing.Size(463, 252);
            this.dataGridViewRute.TabIndex = 27;
            this.dataGridViewRute.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRute_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(27, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 63;
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
            this.comboBoxStatus.Location = new System.Drawing.Point(105, 131);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(188, 30);
            this.comboBoxStatus.TabIndex = 62;
            // 
            // tbnama
            // 
            this.tbnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbnama.Location = new System.Drawing.Point(105, 65);
            this.tbnama.Margin = new System.Windows.Forms.Padding(4);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(318, 28);
            this.tbnama.TabIndex = 60;
            // 
            // tbidrute
            // 
            this.tbidrute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbidrute.Location = new System.Drawing.Point(105, 32);
            this.tbidrute.Margin = new System.Windows.Forms.Padding(4);
            this.tbidrute.Name = "tbidrute";
            this.tbidrute.ReadOnly = true;
            this.tbidrute.Size = new System.Drawing.Size(110, 28);
            this.tbidrute.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nama :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "ID Rute  :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nUPPPM
            // 
            this.nUPPPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nUPPPM.Location = new System.Drawing.Point(139, 98);
            this.nUPPPM.Margin = new System.Windows.Forms.Padding(4);
            this.nUPPPM.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nUPPPM.Name = "nUPPPM";
            this.nUPPPM.Size = new System.Drawing.Size(284, 28);
            this.nUPPPM.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(101, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 24);
            this.label5.TabIndex = 65;
            this.label5.Text = "Rp.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 64;
            this.label4.Text = "PPM :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(426, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 68;
            this.label3.Text = "Daftar Rute";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 70;
            this.label6.Text = "Detail Rute";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridViewDRute
            // 
            this.dataGridViewDRute.AllowUserToAddRows = false;
            this.dataGridViewDRute.AllowUserToDeleteRows = false;
            this.dataGridViewDRute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDRute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stasiun_Ke,
            this.Id_Stasiun,
            this.Nama,
            this.Jarak_Next});
            this.dataGridViewDRute.Location = new System.Drawing.Point(10, 430);
            this.dataGridViewDRute.Name = "dataGridViewDRute";
            this.dataGridViewDRute.ReadOnly = true;
            this.dataGridViewDRute.RowHeadersVisible = false;
            this.dataGridViewDRute.RowHeadersWidth = 51;
            this.dataGridViewDRute.RowTemplate.Height = 24;
            this.dataGridViewDRute.Size = new System.Drawing.Size(414, 202);
            this.dataGridViewDRute.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(426, 322);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 72;
            this.label8.Text = "Daftar Stasiun";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridViewStasiun
            // 
            this.dataGridViewStasiun.AllowUserToAddRows = false;
            this.dataGridViewStasiun.AllowUserToDeleteRows = false;
            this.dataGridViewStasiun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStasiun.Location = new System.Drawing.Point(430, 355);
            this.dataGridViewStasiun.Name = "dataGridViewStasiun";
            this.dataGridViewStasiun.ReadOnly = true;
            this.dataGridViewStasiun.RowHeadersVisible = false;
            this.dataGridViewStasiun.RowHeadersWidth = 51;
            this.dataGridViewStasiun.RowTemplate.Height = 24;
            this.dataGridViewStasiun.Size = new System.Drawing.Size(464, 277);
            this.dataGridViewStasiun.TabIndex = 71;
            this.dataGridViewStasiun.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStasiun_CellDoubleClick);
            // 
            // buttonTambah
            // 
            this.buttonTambah.AutoSize = true;
            this.buttonTambah.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonTambah.Location = new System.Drawing.Point(168, 167);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(125, 38);
            this.buttonTambah.TabIndex = 73;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonUpdate.Location = new System.Drawing.Point(299, 167);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(125, 38);
            this.buttonUpdate.TabIndex = 74;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.AutoSize = true;
            this.buttonReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonReset.Location = new System.Drawing.Point(299, 387);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(125, 38);
            this.buttonReset.TabIndex = 75;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonTambahStasiun
            // 
            this.buttonTambahStasiun.AutoSize = true;
            this.buttonTambahStasiun.Enabled = false;
            this.buttonTambahStasiun.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonTambahStasiun.Location = new System.Drawing.Point(168, 387);
            this.buttonTambahStasiun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambahStasiun.Name = "buttonTambahStasiun";
            this.buttonTambahStasiun.Size = new System.Drawing.Size(125, 38);
            this.buttonTambahStasiun.TabIndex = 76;
            this.buttonTambahStasiun.Text = "Tambah";
            this.buttonTambahStasiun.UseVisualStyleBackColor = true;
            this.buttonTambahStasiun.Click += new System.EventHandler(this.buttonTambahStasiun_Click);
            // 
            // numericUpDownJarak
            // 
            this.numericUpDownJarak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numericUpDownJarak.Location = new System.Drawing.Point(123, 347);
            this.numericUpDownJarak.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownJarak.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numericUpDownJarak.Name = "numericUpDownJarak";
            this.numericUpDownJarak.Size = new System.Drawing.Size(256, 28);
            this.numericUpDownJarak.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(7, 347);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 24);
            this.label9.TabIndex = 77;
            this.label9.Text = "Jarak Next :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxIdStasiun
            // 
            this.textBoxIdStasiun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxIdStasiun.Location = new System.Drawing.Point(123, 239);
            this.textBoxIdStasiun.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdStasiun.Name = "textBoxIdStasiun";
            this.textBoxIdStasiun.ReadOnly = true;
            this.textBoxIdStasiun.Size = new System.Drawing.Size(110, 28);
            this.textBoxIdStasiun.TabIndex = 80;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 243);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 24);
            this.label10.TabIndex = 79;
            this.label10.Text = "ID Stasiun  :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxNamaStasiun
            // 
            this.textBoxNamaStasiun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxNamaStasiun.Location = new System.Drawing.Point(123, 275);
            this.textBoxNamaStasiun.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNamaStasiun.Name = "textBoxNamaStasiun";
            this.textBoxNamaStasiun.ReadOnly = true;
            this.textBoxNamaStasiun.Size = new System.Drawing.Size(295, 28);
            this.textBoxNamaStasiun.TabIndex = 82;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(39, 277);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 24);
            this.label11.TabIndex = 81;
            this.label11.Text = "Nama  :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClear.Location = new System.Drawing.Point(37, 167);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(125, 38);
            this.buttonClear.TabIndex = 83;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClearDRute
            // 
            this.buttonClearDRute.AutoSize = true;
            this.buttonClearDRute.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClearDRute.Location = new System.Drawing.Point(37, 387);
            this.buttonClearDRute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClearDRute.Name = "buttonClearDRute";
            this.buttonClearDRute.Size = new System.Drawing.Size(125, 38);
            this.buttonClearDRute.TabIndex = 84;
            this.buttonClearDRute.Text = "Clear";
            this.buttonClearDRute.UseVisualStyleBackColor = true;
            this.buttonClearDRute.Click += new System.EventHandler(this.buttonClearDRute_Click);
            // 
            // textBoxSearchRute
            // 
            this.textBoxSearchRute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSearchRute.Location = new System.Drawing.Point(688, 33);
            this.textBoxSearchRute.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchRute.Name = "textBoxSearchRute";
            this.textBoxSearchRute.Size = new System.Drawing.Size(205, 28);
            this.textBoxSearchRute.TabIndex = 85;
            this.textBoxSearchRute.TextChanged += new System.EventHandler(this.textBoxSearchRute_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(600, 33);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 24);
            this.label12.TabIndex = 86;
            this.label12.Text = "Search :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(600, 324);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 24);
            this.label13.TabIndex = 88;
            this.label13.Text = "Search :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxSearchStasiun
            // 
            this.textBoxSearchStasiun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSearchStasiun.Location = new System.Drawing.Point(688, 320);
            this.textBoxSearchStasiun.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchStasiun.Name = "textBoxSearchStasiun";
            this.textBoxSearchStasiun.Size = new System.Drawing.Size(205, 28);
            this.textBoxSearchStasiun.TabIndex = 87;
            this.textBoxSearchStasiun.TextChanged += new System.EventHandler(this.textBoxSearchStasiun_TextChanged);
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxAlamat.Location = new System.Drawing.Point(123, 311);
            this.textBoxAlamat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.ReadOnly = true;
            this.textBoxAlamat.Size = new System.Drawing.Size(295, 28);
            this.textBoxAlamat.TabIndex = 90;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(33, 313);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 24);
            this.label14.TabIndex = 89;
            this.label14.Text = "Alamat  :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Stasiun_Ke
            // 
            this.Stasiun_Ke.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Stasiun_Ke.FillWeight = 60F;
            this.Stasiun_Ke.Frozen = true;
            this.Stasiun_Ke.HeaderText = "Stasiun_Ke";
            this.Stasiun_Ke.MinimumWidth = 6;
            this.Stasiun_Ke.Name = "Stasiun_Ke";
            this.Stasiun_Ke.ReadOnly = true;
            this.Stasiun_Ke.Width = 95;
            // 
            // Id_Stasiun
            // 
            this.Id_Stasiun.HeaderText = "Id_Stasiun";
            this.Id_Stasiun.MinimumWidth = 6;
            this.Id_Stasiun.Name = "Id_Stasiun";
            this.Id_Stasiun.ReadOnly = true;
            this.Id_Stasiun.Visible = false;
            this.Id_Stasiun.Width = 125;
            // 
            // Nama
            // 
            this.Nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            // 
            // Jarak_Next
            // 
            this.Jarak_Next.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Jarak_Next.HeaderText = "Jarak_Next";
            this.Jarak_Next.MinimumWidth = 6;
            this.Jarak_Next.Name = "Jarak_Next";
            this.Jarak_Next.ReadOnly = true;
            // 
            // FormMasterRute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 644);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxSearchStasiun);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxSearchRute);
            this.Controls.Add(this.buttonClearDRute);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxNamaStasiun);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxIdStasiun);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDownJarak);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonTambahStasiun);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewStasiun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewDRute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nUPPPM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.tbidrute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRute);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMasterRute";
            this.Text = "Master Rute";
            this.Load += new System.EventHandler(this.FormMasterRute_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPPPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDRute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStasiun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJarak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kembaliKeMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterTransaksiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewRute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.TextBox tbidrute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUPPPM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewDRute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewStasiun;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonTambahStasiun;
        private System.Windows.Forms.NumericUpDown numericUpDownJarak;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxIdStasiun;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNamaStasiun;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClearDRute;
        private System.Windows.Forms.TextBox textBoxSearchRute;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSearchStasiun;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stasiun_Ke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Stasiun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jarak_Next;
    }
}