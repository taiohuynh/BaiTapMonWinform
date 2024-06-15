namespace B4_Bai1_N2_6_Phap
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
            this.lblMa_6_Phap = new System.Windows.Forms.Label();
            this.lblTen_6_Phap = new System.Windows.Forms.Label();
            this.txtMa_6_Phap = new System.Windows.Forms.TextBox();
            this.txtTen_6_Phap = new System.Windows.Forms.TextBox();
            this.btnLuu_6_Phap = new System.Windows.Forms.Button();
            this.btnXoa_6_Phap = new System.Windows.Forms.Button();
            this.lstBx1_6_Phap = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblMa_6_Phap
            // 
            this.lblMa_6_Phap.AutoSize = true;
            this.lblMa_6_Phap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMa_6_Phap.Location = new System.Drawing.Point(43, 39);
            this.lblMa_6_Phap.Name = "lblMa_6_Phap";
            this.lblMa_6_Phap.Size = new System.Drawing.Size(32, 19);
            this.lblMa_6_Phap.TabIndex = 0;
            this.lblMa_6_Phap.Text = "Mã:";
            // 
            // lblTen_6_Phap
            // 
            this.lblTen_6_Phap.AutoSize = true;
            this.lblTen_6_Phap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTen_6_Phap.Location = new System.Drawing.Point(42, 83);
            this.lblTen_6_Phap.Name = "lblTen_6_Phap";
            this.lblTen_6_Phap.Size = new System.Drawing.Size(33, 19);
            this.lblTen_6_Phap.TabIndex = 1;
            this.lblTen_6_Phap.Text = "Tên:";
            // 
            // txtMa_6_Phap
            // 
            this.txtMa_6_Phap.Location = new System.Drawing.Point(103, 35);
            this.txtMa_6_Phap.Name = "txtMa_6_Phap";
            this.txtMa_6_Phap.Size = new System.Drawing.Size(140, 25);
            this.txtMa_6_Phap.TabIndex = 2;
            // 
            // txtTen_6_Phap
            // 
            this.txtTen_6_Phap.Location = new System.Drawing.Point(103, 80);
            this.txtTen_6_Phap.Name = "txtTen_6_Phap";
            this.txtTen_6_Phap.Size = new System.Drawing.Size(140, 25);
            this.txtTen_6_Phap.TabIndex = 3;
            // 
            // btnLuu_6_Phap
            // 
            this.btnLuu_6_Phap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLuu_6_Phap.Location = new System.Drawing.Point(62, 128);
            this.btnLuu_6_Phap.Name = "btnLuu_6_Phap";
            this.btnLuu_6_Phap.Size = new System.Drawing.Size(75, 34);
            this.btnLuu_6_Phap.TabIndex = 4;
            this.btnLuu_6_Phap.Text = "Lưu";
            this.btnLuu_6_Phap.UseVisualStyleBackColor = true;
            this.btnLuu_6_Phap.Click += new System.EventHandler(this.btnLuu_6_Phap_Click);
            // 
            // btnXoa_6_Phap
            // 
            this.btnXoa_6_Phap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoa_6_Phap.Location = new System.Drawing.Point(154, 128);
            this.btnXoa_6_Phap.Name = "btnXoa_6_Phap";
            this.btnXoa_6_Phap.Size = new System.Drawing.Size(75, 34);
            this.btnXoa_6_Phap.TabIndex = 5;
            this.btnXoa_6_Phap.Text = "Xóa";
            this.btnXoa_6_Phap.UseVisualStyleBackColor = true;
            this.btnXoa_6_Phap.Click += new System.EventHandler(this.btnXoa_6_Phap_Click);
            // 
            // lstBx1_6_Phap
            // 
            this.lstBx1_6_Phap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBx1_6_Phap.FormattingEnabled = true;
            this.lstBx1_6_Phap.ItemHeight = 17;
            this.lstBx1_6_Phap.Location = new System.Drawing.Point(42, 182);
            this.lstBx1_6_Phap.Name = "lstBx1_6_Phap";
            this.lstBx1_6_Phap.Size = new System.Drawing.Size(204, 106);
            this.lstBx1_6_Phap.TabIndex = 6;
            // 
            // frmMain_6_Phap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 330);
            this.Controls.Add(this.lstBx1_6_Phap);
            this.Controls.Add(this.btnXoa_6_Phap);
            this.Controls.Add(this.btnLuu_6_Phap);
            this.Controls.Add(this.txtTen_6_Phap);
            this.Controls.Add(this.txtMa_6_Phap);
            this.Controls.Add(this.lblTen_6_Phap);
            this.Controls.Add(this.lblMa_6_Phap);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmMain_6_Phap";
            this.Text = "Bai1_6_Phap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMa_6_Phap;
        private System.Windows.Forms.Label lblTen_6_Phap;
        private System.Windows.Forms.TextBox txtMa_6_Phap;
        private System.Windows.Forms.TextBox txtTen_6_Phap;
        private System.Windows.Forms.Button btnLuu_6_Phap;
        private System.Windows.Forms.Button btnXoa_6_Phap;
        private System.Windows.Forms.ListBox lstBx1_6_Phap;
    }
}
