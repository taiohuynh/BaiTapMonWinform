
namespace _6_Phap_B2_N2_Bai1
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
            this.lbGio_6_Phap = new System.Windows.Forms.Label();
            this.lbPhut_6_Phap = new System.Windows.Forms.Label();
            this.lbGiay_6_Phap = new System.Windows.Forms.Label();
            this.txtHour_6_Phap = new System.Windows.Forms.TextBox();
            this.txtMinute_6_Phap = new System.Windows.Forms.TextBox();
            this.txtSecond_6_Phap = new System.Windows.Forms.TextBox();
            this.btnShowTime_6_Phap = new System.Windows.Forms.Button();
            this.lbTime_6_Phap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbGio_6_Phap
            // 
            this.lbGio_6_Phap.AutoSize = true;
            this.lbGio_6_Phap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGio_6_Phap.Location = new System.Drawing.Point(61, 48);
            this.lbGio_6_Phap.Name = "lbGio_6_Phap";
            this.lbGio_6_Phap.Size = new System.Drawing.Size(78, 21);
            this.lbGio_6_Phap.TabIndex = 0;
            this.lbGio_6_Phap.Text = "Nhập giờ:";
            // 
            // lbPhut_6_Phap
            // 
            this.lbPhut_6_Phap.AutoSize = true;
            this.lbPhut_6_Phap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhut_6_Phap.Location = new System.Drawing.Point(61, 93);
            this.lbPhut_6_Phap.Name = "lbPhut_6_Phap";
            this.lbPhut_6_Phap.Size = new System.Drawing.Size(87, 21);
            this.lbPhut_6_Phap.TabIndex = 1;
            this.lbPhut_6_Phap.Text = "Nhập phút:";
            // 
            // lbGiay_6_Phap
            // 
            this.lbGiay_6_Phap.AutoSize = true;
            this.lbGiay_6_Phap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGiay_6_Phap.Location = new System.Drawing.Point(61, 138);
            this.lbGiay_6_Phap.Name = "lbGiay_6_Phap";
            this.lbGiay_6_Phap.Size = new System.Drawing.Size(84, 21);
            this.lbGiay_6_Phap.TabIndex = 2;
            this.lbGiay_6_Phap.Text = "Nhập giây:";
            // 
            // txtHour_6_Phap
            // 
            this.txtHour_6_Phap.Location = new System.Drawing.Point(173, 48);
            this.txtHour_6_Phap.Name = "txtHour_6_Phap";
            this.txtHour_6_Phap.Size = new System.Drawing.Size(143, 23);
            this.txtHour_6_Phap.TabIndex = 3;
            this.txtHour_6_Phap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMinute_6_Phap
            // 
            this.txtMinute_6_Phap.Location = new System.Drawing.Point(173, 93);
            this.txtMinute_6_Phap.Name = "txtMinute_6_Phap";
            this.txtMinute_6_Phap.Size = new System.Drawing.Size(143, 23);
            this.txtMinute_6_Phap.TabIndex = 4;
            this.txtMinute_6_Phap.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSecond_6_Phap
            // 
            this.txtSecond_6_Phap.Location = new System.Drawing.Point(173, 138);
            this.txtSecond_6_Phap.Name = "txtSecond_6_Phap";
            this.txtSecond_6_Phap.Size = new System.Drawing.Size(143, 23);
            this.txtSecond_6_Phap.TabIndex = 5;
            this.txtSecond_6_Phap.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnShowTime_6_Phap
            // 
            this.btnShowTime_6_Phap.Location = new System.Drawing.Point(60, 199);
            this.btnShowTime_6_Phap.Name = "btnShowTime_6_Phap";
            this.btnShowTime_6_Phap.Size = new System.Drawing.Size(87, 29);
            this.btnShowTime_6_Phap.TabIndex = 6;
            this.btnShowTime_6_Phap.Text = "Hiển thị";
            this.btnShowTime_6_Phap.UseVisualStyleBackColor = true;
            this.btnShowTime_6_Phap.Click += new System.EventHandler(this.btnShowTime_6_Phap_Click);
            // 
            // lbTime_6_Phap
            // 
            this.lbTime_6_Phap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTime_6_Phap.Location = new System.Drawing.Point(179, 198);
            this.lbTime_6_Phap.Name = "lbTime_6_Phap";
            this.lbTime_6_Phap.Size = new System.Drawing.Size(132, 30);
            this.lbTime_6_Phap.TabIndex = 8;
            this.lbTime_6_Phap.Text = "                                         ";
            this.lbTime_6_Phap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTime_6_Phap.Click += new System.EventHandler(this.lbTime_Click);
            // 
            // frmMain_6_Phap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 279);
            this.Controls.Add(this.lbTime_6_Phap);
            this.Controls.Add(this.btnShowTime_6_Phap);
            this.Controls.Add(this.txtSecond_6_Phap);
            this.Controls.Add(this.txtMinute_6_Phap);
            this.Controls.Add(this.txtHour_6_Phap);
            this.Controls.Add(this.lbGiay_6_Phap);
            this.Controls.Add(this.lbPhut_6_Phap);
            this.Controls.Add(this.lbGio_6_Phap);
            this.Name = "frmMain_6_Phap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StructDemo_6_Phap";
            this.Load += new System.EventHandler(this.frmMain_6Phap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGio_6_Phap;
        private System.Windows.Forms.Label lbPhut_6_Phap;
        private System.Windows.Forms.Label lbGiay_6_Phap;
        private System.Windows.Forms.TextBox txtHour_6_Phap;
        private System.Windows.Forms.TextBox txtMinute_6_Phap;
        private System.Windows.Forms.TextBox txtSecond_6_Phap;
        private System.Windows.Forms.Button btnShowTime_6_Phap;
        private System.Windows.Forms.Label lbTime_6_Phap;
    }
}

