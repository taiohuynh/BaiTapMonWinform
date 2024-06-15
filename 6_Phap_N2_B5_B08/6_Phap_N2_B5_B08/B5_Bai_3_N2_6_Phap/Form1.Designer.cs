
namespace B5_Bai_3_N2_6_Phap
{
    partial class frmMain_6_Phap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1_6_Phap = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem_6_Phap = new System.Windows.Forms.ToolStripMenuItem();
            this.drawByMouseToolStripMenuItem_6_Phap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem_6_Phap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1_6_Phap.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1_6_Phap
            // 
            this.menuStrip1_6_Phap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem_6_Phap});
            this.menuStrip1_6_Phap.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1_6_Phap.Name = "menuStrip1_6_Phap";
            this.menuStrip1_6_Phap.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1_6_Phap.TabIndex = 0;
            this.menuStrip1_6_Phap.Text = "menuStrip1_6_Phap";
            // 
            // fileToolStripMenuItem_6_Phap
            // 
            this.fileToolStripMenuItem_6_Phap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawByMouseToolStripMenuItem_6_Phap,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem_6_Phap});
            this.fileToolStripMenuItem_6_Phap.Name = "fileToolStripMenuItem_6_Phap";
            this.fileToolStripMenuItem_6_Phap.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem_6_Phap.Text = "File";
            // 
            // drawByMouseToolStripMenuItem_6_Phap
            // 
            this.drawByMouseToolStripMenuItem_6_Phap.Name = "drawByMouseToolStripMenuItem_6_Phap";
            this.drawByMouseToolStripMenuItem_6_Phap.Size = new System.Drawing.Size(180, 22);
            this.drawByMouseToolStripMenuItem_6_Phap.Text = "Draw By Mouse";
            this.drawByMouseToolStripMenuItem_6_Phap.Click += new System.EventHandler(this.drawByMouseToolStripMenuItem_6_Phap_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem_6_Phap
            // 
            this.exitToolStripMenuItem_6_Phap.Name = "exitToolStripMenuItem_6_Phap";
            this.exitToolStripMenuItem_6_Phap.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem_6_Phap.Text = "Exit";
            this.exitToolStripMenuItem_6_Phap.Click += new System.EventHandler(this.exitToolStripMenuItem_6_Phap_Click);
            // 
            // frmMain_6_Phap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 190);
            this.Controls.Add(this.menuStrip1_6_Phap);
            this.MainMenuStrip = this.menuStrip1_6_Phap;
            this.Name = "frmMain_6_Phap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai_3_Do_Hoa_6_Phap";
            this.menuStrip1_6_Phap.ResumeLayout(false);
            this.menuStrip1_6_Phap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1_6_Phap;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem_6_Phap;
        private System.Windows.Forms.ToolStripMenuItem drawByMouseToolStripMenuItem_6_Phap;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem_6_Phap;
    }
}

