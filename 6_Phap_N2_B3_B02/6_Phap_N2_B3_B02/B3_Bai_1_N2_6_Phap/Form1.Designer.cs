
namespace B3_Bai_1_N2_6_Phap
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
            this.lblKQ_6_Phap = new System.Windows.Forms.Label();
            this.btnIn_6_Phap = new System.Windows.Forms.Button();
            this.btnXoa_6_Phap = new System.Windows.Forms.Button();
            this.btnDung_6_Phap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKQ_6Phap
            // 
            this.lblKQ_6_Phap.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblKQ_6_Phap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKQ_6_Phap.Location = new System.Drawing.Point(51, 33);
            this.lblKQ_6_Phap.Name = "lblKQ_6Phap";
            this.lblKQ_6_Phap.Size = new System.Drawing.Size(276, 50);
            this.lblKQ_6_Phap.TabIndex = 0;
            // 
            // btnIn_6Phap
            // 
            this.btnIn_6_Phap.Location = new System.Drawing.Point(51, 108);
            this.btnIn_6_Phap.Name = "btnIn_6Phap";
            this.btnIn_6_Phap.Size = new System.Drawing.Size(75, 23);
            this.btnIn_6_Phap.TabIndex = 1;
            this.btnIn_6_Phap.Text = "In mảng";
            this.btnIn_6_Phap.UseVisualStyleBackColor = true;
            this.btnIn_6_Phap.Click += new System.EventHandler(this.btnIn_6_Phap_Click);
            // 
            // btnXoa_6Phap
            // 
            this.btnXoa_6_Phap.Location = new System.Drawing.Point(152, 108);
            this.btnXoa_6_Phap.Name = "btnXoa_6Phap";
            this.btnXoa_6_Phap.Size = new System.Drawing.Size(75, 23);
            this.btnXoa_6_Phap.TabIndex = 2;
            this.btnXoa_6_Phap.Text = "Xóa";
            this.btnXoa_6_Phap.UseVisualStyleBackColor = true;
            this.btnXoa_6_Phap.Click += new System.EventHandler(this.btnXoa_6_Phap_Click);
            // 
            // btnDung_6Phap
            // 
            this.btnDung_6_Phap.Location = new System.Drawing.Point(252, 108);
            this.btnDung_6_Phap.Name = "btnDung_6Phap";
            this.btnDung_6_Phap.Size = new System.Drawing.Size(75, 23);
            this.btnDung_6_Phap.TabIndex = 3;
            this.btnDung_6_Phap.Text = "Dừng";
            this.btnDung_6_Phap.UseVisualStyleBackColor = true;
            this.btnDung_6_Phap.Click += new System.EventHandler(this.btnDung_6_Phap_Click);
            // 
            // frmMain_6Phap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 169);
            this.Controls.Add(this.btnDung_6_Phap);
            this.Controls.Add(this.btnXoa_6_Phap);
            this.Controls.Add(this.btnIn_6_Phap);
            this.Controls.Add(this.lblKQ_6_Phap);
            this.Name = "frmMain_6_Phap";
            this.Text = "MảngSốNguyên_6_Phap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKQ_6_Phap;
        private System.Windows.Forms.Button btnIn_6_Phap;
        private System.Windows.Forms.Button btnXoa_6_Phap;
        private System.Windows.Forms.Button btnDung_6_Phap;
    }
}

