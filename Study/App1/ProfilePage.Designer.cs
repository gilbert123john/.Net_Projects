namespace App1
{
    partial class ProfilePage
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
            this.lblDes = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(40, 57);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(45, 23);
            this.lblDes.TabIndex = 2;
            this.lblDes.Text = "post";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(38, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(153, 32);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Head Name";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(610, 774);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(149, 53);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(202, 114);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(110, 22);
            this.lblDesignation.TabIndex = 4;
            this.lblDesignation.Text = "Desigination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Summary";
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 858);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblName);
            this.Name = "ProfilePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfilePage";
            this.Load += new System.EventHandler(this.ProfilePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label label1;
    }
}