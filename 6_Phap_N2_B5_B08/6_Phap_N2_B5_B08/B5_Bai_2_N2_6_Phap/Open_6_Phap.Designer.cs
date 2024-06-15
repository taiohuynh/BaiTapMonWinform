namespace B5_Bai_2_N2_6_Phap
{
    partial class Open_6_Phap
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
            this.btnMau_6_Phap = new System.Windows.Forms.Button();
            this.contextMenuStrip1_6_Phap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.redToolStripMenuItem_6_Phap = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem_6_Phap = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem_6_Phap = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1_6_Phap.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMau_6_Phap
            // 
            this.btnMau_6_Phap.ContextMenuStrip = this.contextMenuStrip1_6_Phap;
            this.btnMau_6_Phap.Location = new System.Drawing.Point(12, 130);
            this.btnMau_6_Phap.Name = "btnMau_6_Phap";
            this.btnMau_6_Phap.Size = new System.Drawing.Size(291, 41);
            this.btnMau_6_Phap.TabIndex = 0;
            this.btnMau_6_Phap.Text = "Màu";
            this.btnMau_6_Phap.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1_6_Phap
            // 
            this.contextMenuStrip1_6_Phap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem_6_Phap,
            this.greenToolStripMenuItem_6_Phap,
            this.blueToolStripMenuItem_6_Phap});
            this.contextMenuStrip1_6_Phap.Name = "contextMenuStrip1_6_Phap";
            this.contextMenuStrip1_6_Phap.Size = new System.Drawing.Size(106, 70);
            // 
            // redToolStripMenuItem_6_Phap
            // 
            this.redToolStripMenuItem_6_Phap.Name = "redToolStripMenuItem_6_Phap";
            this.redToolStripMenuItem_6_Phap.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem_6_Phap.Text = "Red";
            this.redToolStripMenuItem_6_Phap.Click += new System.EventHandler(this.redToolStripMenuItem_6_Phap_Click);
            // 
            // greenToolStripMenuItem_6_Phap
            // 
            this.greenToolStripMenuItem_6_Phap.Name = "greenToolStripMenuItem_6_Phap";
            this.greenToolStripMenuItem_6_Phap.Size = new System.Drawing.Size(180, 22);
            this.greenToolStripMenuItem_6_Phap.Text = "Green";
            this.greenToolStripMenuItem_6_Phap.Click += new System.EventHandler(this.greenToolStripMenuItem_6_Phap_Click);
            // 
            // blueToolStripMenuItem_6_Phap
            // 
            this.blueToolStripMenuItem_6_Phap.Name = "blueToolStripMenuItem_6_Phap";
            this.blueToolStripMenuItem_6_Phap.Size = new System.Drawing.Size(180, 22);
            this.blueToolStripMenuItem_6_Phap.Text = "Blue";
            this.blueToolStripMenuItem_6_Phap.Click += new System.EventHandler(this.blueToolStripMenuItem_6_Phap_Click);
            // 
            // Open_6_Phap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 183);
            this.Controls.Add(this.btnMau_6_Phap);
            this.Name = "Open_6_Phap";
            this.Text = "ContextStrip_Button_6_Phap";
            this.contextMenuStrip1_6_Phap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMau_6_Phap;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1_6_Phap;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem_6_Phap;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem_6_Phap;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem_6_Phap;
    }
}