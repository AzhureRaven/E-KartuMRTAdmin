
namespace E_KartuMRTAdmin
{
    partial class FormMenu
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
            this.masterRuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterStasiunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterKeretaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterRuteToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.masterStasiunToolStripMenuItem,
            this.masterKeretaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterRuteToolStripMenuItem
            // 
            this.masterRuteToolStripMenuItem.Name = "masterRuteToolStripMenuItem";
            this.masterRuteToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.masterRuteToolStripMenuItem.Text = "Master Rute";
            this.masterRuteToolStripMenuItem.Click += new System.EventHandler(this.masterRuteToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // masterStasiunToolStripMenuItem
            // 
            this.masterStasiunToolStripMenuItem.Name = "masterStasiunToolStripMenuItem";
            this.masterStasiunToolStripMenuItem.Size = new System.Drawing.Size(149, 29);
            this.masterStasiunToolStripMenuItem.Text = "Master Stasiun";
            this.masterStasiunToolStripMenuItem.Click += new System.EventHandler(this.masterStasiunToolStripMenuItem_Click);
            // 
            // masterKeretaToolStripMenuItem
            // 
            this.masterKeretaToolStripMenuItem.Name = "masterKeretaToolStripMenuItem";
            this.masterKeretaToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
            this.masterKeretaToolStripMenuItem.Text = "Master Kereta";
            this.masterKeretaToolStripMenuItem.Click += new System.EventHandler(this.masterKeretaToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterRuteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterStasiunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterKeretaToolStripMenuItem;
    }
}