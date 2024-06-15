
namespace B5_Bai_4_N2_6_Phap
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
            this.pcbx_6_Phap = new System.Windows.Forms.PictureBox();
            this.btnOpen_6_Phap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_6_Phap)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbx_6_Phap
            // 
            this.pcbx_6_Phap.Location = new System.Drawing.Point(12, 12);
            this.pcbx_6_Phap.Name = "pcbx_6_Phap";
            this.pcbx_6_Phap.Size = new System.Drawing.Size(278, 269);
            this.pcbx_6_Phap.TabIndex = 0;
            this.pcbx_6_Phap.TabStop = false;
            // 
            // btnOpen_6_Phap
            // 
            this.btnOpen_6_Phap.Location = new System.Drawing.Point(298, 246);
            this.btnOpen_6_Phap.Name = "btnOpen_6_Phap";
            this.btnOpen_6_Phap.Size = new System.Drawing.Size(137, 37);
            this.btnOpen_6_Phap.TabIndex = 1;
            this.btnOpen_6_Phap.Text = "Open";
            this.btnOpen_6_Phap.UseVisualStyleBackColor = true;
            this.btnOpen_6_Phap.Click += new System.EventHandler(this.btnOpen_6_Phap_Click);
            // 
            // frmMain_6_Phap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 295);
            this.Controls.Add(this.btnOpen_6_Phap);
            this.Controls.Add(this.pcbx_6_Phap);
            this.Name = "frmMain_6_Phap";
            this.Text = "Open_Dialog_6_Phap";
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_6_Phap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbx_6_Phap;
        private System.Windows.Forms.Button btnOpen_6_Phap;
    }
}

