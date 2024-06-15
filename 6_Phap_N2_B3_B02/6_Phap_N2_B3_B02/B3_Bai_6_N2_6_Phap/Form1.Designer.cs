namespace B3_Bai_6_N2_6_Phap
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
            this.clbTrai_6_Phap = new System.Windows.Forms.CheckedListBox();
            this.clbPhai_6_Phap = new System.Windows.Forms.CheckedListBox();
            this.btnAddPhai_6_Phap = new System.Windows.Forms.Button();
            this.btnAddAllPhai_6_Phap = new System.Windows.Forms.Button();
            this.btnAddTrai_6_Phap = new System.Windows.Forms.Button();
            this.btnAddAllTrai_6_Phap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbTrai_6_Phap
            // 
            this.clbTrai_6_Phap.FormattingEnabled = true;
            this.clbTrai_6_Phap.Items.AddRange(new object[] {
            "Tèo",
            "Tí",
            "Heo",
            "Gà"});
            this.clbTrai_6_Phap.Location = new System.Drawing.Point(39, 36);
            this.clbTrai_6_Phap.Name = "clbTrai_6_Phap";
            this.clbTrai_6_Phap.Size = new System.Drawing.Size(120, 130);
            this.clbTrai_6_Phap.TabIndex = 0;
            // 
            // clbPhai_6_Phap
            // 
            this.clbPhai_6_Phap.FormattingEnabled = true;
            this.clbPhai_6_Phap.Location = new System.Drawing.Point(256, 36);
            this.clbPhai_6_Phap.Name = "clbPhai_6_Phap";
            this.clbPhai_6_Phap.Size = new System.Drawing.Size(120, 130);
            this.clbPhai_6_Phap.TabIndex = 1;
            // 
            // btnAddPhai_6_Phap
            // 
            this.btnAddPhai_6_Phap.Location = new System.Drawing.Point(177, 36);
            this.btnAddPhai_6_Phap.Name = "btnAddPhai_6_Phap";
            this.btnAddPhai_6_Phap.Size = new System.Drawing.Size(59, 28);
            this.btnAddPhai_6_Phap.TabIndex = 2;
            this.btnAddPhai_6_Phap.Text = ">";
            this.btnAddPhai_6_Phap.UseVisualStyleBackColor = true;
            this.btnAddPhai_6_Phap.Click += new System.EventHandler(this.btnAddPhai_6_Phap_Click);
            // 
            // btnAddAllPhai_6_Phap
            // 
            this.btnAddAllPhai_6_Phap.Location = new System.Drawing.Point(177, 70);
            this.btnAddAllPhai_6_Phap.Name = "btnAddAllPhai_6_Phap";
            this.btnAddAllPhai_6_Phap.Size = new System.Drawing.Size(59, 28);
            this.btnAddAllPhai_6_Phap.TabIndex = 3;
            this.btnAddAllPhai_6_Phap.Text = ">>";
            this.btnAddAllPhai_6_Phap.UseVisualStyleBackColor = true;
            this.btnAddAllPhai_6_Phap.Click += new System.EventHandler(this.btnAddAllPhai_6_Phap_Click);
            // 
            // btnAddTrai_6_Phap
            // 
            this.btnAddTrai_6_Phap.Location = new System.Drawing.Point(177, 104);
            this.btnAddTrai_6_Phap.Name = "btnAddTrai_6_Phap";
            this.btnAddTrai_6_Phap.Size = new System.Drawing.Size(59, 28);
            this.btnAddTrai_6_Phap.TabIndex = 4;
            this.btnAddTrai_6_Phap.Text = "<";
            this.btnAddTrai_6_Phap.UseVisualStyleBackColor = true;
            this.btnAddTrai_6_Phap.Click += new System.EventHandler(this.btnAddTrai_6_Phap_Click);
            // 
            // btnAddAllTrai_6_Phap
            // 
            this.btnAddAllTrai_6_Phap.Location = new System.Drawing.Point(177, 138);
            this.btnAddAllTrai_6_Phap.Name = "btnAddAllTrai_6_Phap";
            this.btnAddAllTrai_6_Phap.Size = new System.Drawing.Size(59, 28);
            this.btnAddAllTrai_6_Phap.TabIndex = 5;
            this.btnAddAllTrai_6_Phap.Text = "<<";
            this.btnAddAllTrai_6_Phap.UseVisualStyleBackColor = true;
            this.btnAddAllTrai_6_Phap.Click += new System.EventHandler(this.btnAddAllTrai_6_Phap_Click);
            // 
            // frmMain_6_Phap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 206);
            this.Controls.Add(this.btnAddAllTrai_6_Phap);
            this.Controls.Add(this.btnAddTrai_6_Phap);
            this.Controls.Add(this.btnAddAllPhai_6_Phap);
            this.Controls.Add(this.btnAddPhai_6_Phap);
            this.Controls.Add(this.clbPhai_6_Phap);
            this.Controls.Add(this.clbTrai_6_Phap);
            this.Name = "frmMain_6_Phap";
            this.Text = "CheckListBox_6_Phap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbTrai_6_Phap;
        private System.Windows.Forms.CheckedListBox clbPhai_6_Phap;
        private System.Windows.Forms.Button btnAddPhai_6_Phap;
        private System.Windows.Forms.Button btnAddAllPhai_6_Phap;
        private System.Windows.Forms.Button btnAddTrai_6_Phap;
        private System.Windows.Forms.Button btnAddAllTrai_6_Phap;
    }
}
