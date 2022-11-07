
namespace E_KartuMRTAdmin
{
    partial class FormMasterKereta
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
            this.textBoxSearchKereta = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudGerbong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.tbidKereta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewKereta = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRute = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGerbong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKereta)).BeginInit();
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
            this.label12.Location = new System.Drawing.Point(594, 36);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 24);
            this.label12.TabIndex = 102;
            this.label12.Text = "Search :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxSearchKereta
            // 
            this.textBoxSearchKereta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSearchKereta.Location = new System.Drawing.Point(682, 36);
            this.textBoxSearchKereta.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchKereta.Name = "textBoxSearchKereta";
            this.textBoxSearchKereta.Size = new System.Drawing.Size(205, 28);
            this.textBoxSearchKereta.TabIndex = 101;
            this.textBoxSearchKereta.TextChanged += new System.EventHandler(this.textBoxSearchKereta_TextChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClear.Location = new System.Drawing.Point(31, 314);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(125, 38);
            this.buttonClear.TabIndex = 100;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonUpdate.Location = new System.Drawing.Point(293, 314);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(125, 38);
            this.buttonUpdate.TabIndex = 99;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.AutoSize = true;
            this.buttonTambah.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonTambah.Location = new System.Drawing.Point(162, 314);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(125, 38);
            this.buttonTambah.TabIndex = 98;
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
            this.label3.Location = new System.Drawing.Point(420, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 97;
            this.label3.Text = "Daftar Kereta";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nudGerbong
            // 
            this.nudGerbong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudGerbong.Location = new System.Drawing.Point(114, 134);
            this.nudGerbong.Margin = new System.Windows.Forms.Padding(4);
            this.nudGerbong.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudGerbong.Name = "nudGerbong";
            this.nudGerbong.Size = new System.Drawing.Size(303, 28);
            this.nudGerbong.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 94;
            this.label4.Text = "Gerbong :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(36, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 93;
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
            this.comboBoxStatus.Location = new System.Drawing.Point(114, 169);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(188, 30);
            this.comboBoxStatus.TabIndex = 92;
            // 
            // tbnama
            // 
            this.tbnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbnama.Location = new System.Drawing.Point(114, 101);
            this.tbnama.Margin = new System.Windows.Forms.Padding(4);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(303, 28);
            this.tbnama.TabIndex = 91;
            // 
            // tbidKereta
            // 
            this.tbidKereta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbidKereta.Location = new System.Drawing.Point(114, 36);
            this.tbidKereta.Margin = new System.Windows.Forms.Padding(4);
            this.tbidKereta.Name = "tbidKereta";
            this.tbidKereta.ReadOnly = true;
            this.tbidKereta.Size = new System.Drawing.Size(110, 28);
            this.tbidKereta.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 89;
            this.label2.Text = "Nama :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 88;
            this.label1.Text = "ID Kereta  :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridViewKereta
            // 
            this.dataGridViewKereta.AllowUserToAddRows = false;
            this.dataGridViewKereta.AllowUserToDeleteRows = false;
            this.dataGridViewKereta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKereta.Location = new System.Drawing.Point(424, 68);
            this.dataGridViewKereta.Name = "dataGridViewKereta";
            this.dataGridViewKereta.ReadOnly = true;
            this.dataGridViewKereta.RowHeadersVisible = false;
            this.dataGridViewKereta.RowHeadersWidth = 51;
            this.dataGridViewKereta.RowTemplate.Height = 24;
            this.dataGridViewKereta.Size = new System.Drawing.Size(463, 284);
            this.dataGridViewKereta.TabIndex = 87;
            this.dataGridViewKereta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKereta_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 104;
            this.label5.Text = "Stasiun :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxRute
            // 
            this.comboBoxRute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxRute.FormattingEnabled = true;
            this.comboBoxRute.Items.AddRange(new object[] {
            "Maintenance",
            "Aktif",
            "Non-Aktif"});
            this.comboBoxRute.Location = new System.Drawing.Point(114, 68);
            this.comboBoxRute.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRute.Name = "comboBoxRute";
            this.comboBoxRute.Size = new System.Drawing.Size(303, 30);
            this.comboBoxRute.TabIndex = 103;
            // 
            // FormMasterKereta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 371);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxRute);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxSearchKereta);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudGerbong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.tbidKereta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewKereta);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMasterKereta";
            this.Text = "Master Kereta";
            this.Load += new System.EventHandler(this.FormMasterKereta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGerbong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKereta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kembaliKeMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterTransaksiToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSearchKereta;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudGerbong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.TextBox tbidKereta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewKereta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRute;
    }
}