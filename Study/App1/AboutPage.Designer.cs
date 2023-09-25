namespace App1
{
    partial class AboutPage
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
            this.bProgress = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.discriptionBox = new System.Windows.Forms.RichTextBox();
            this.expBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mcaBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bscBox = new System.Windows.Forms.RichTextBox();
            this.projectBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bProgress
            // 
            this.bProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProgress.Location = new System.Drawing.Point(604, 391);
            this.bProgress.Name = "bProgress";
            this.bProgress.Size = new System.Drawing.Size(184, 38);
            this.bProgress.TabIndex = 7;
            this.bProgress.Text = "View Progress";
            this.bProgress.UseVisualStyleBackColor = true;
            this.bProgress.Click += new System.EventHandler(this.bProgress_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Discription";
            // 
            // discriptionBox
            // 
            this.discriptionBox.Location = new System.Drawing.Point(31, 63);
            this.discriptionBox.Name = "discriptionBox";
            this.discriptionBox.Size = new System.Drawing.Size(257, 124);
            this.discriptionBox.TabIndex = 12;
            this.discriptionBox.Text = "";
            // 
            // expBox
            // 
            this.expBox.Location = new System.Drawing.Point(31, 239);
            this.expBox.Name = "expBox";
            this.expBox.Size = new System.Drawing.Size(257, 124);
            this.expBox.TabIndex = 14;
            this.expBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Work Experience";
            // 
            // mcaBox
            // 
            this.mcaBox.Location = new System.Drawing.Point(346, 63);
            this.mcaBox.Name = "mcaBox";
            this.mcaBox.Size = new System.Drawing.Size(423, 48);
            this.mcaBox.TabIndex = 16;
            this.mcaBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Education";
            // 
            // bscBox
            // 
            this.bscBox.Location = new System.Drawing.Point(346, 139);
            this.bscBox.Name = "bscBox";
            this.bscBox.Size = new System.Drawing.Size(423, 48);
            this.bscBox.TabIndex = 17;
            this.bscBox.Text = "";
            // 
            // projectBox
            // 
            this.projectBox.Location = new System.Drawing.Point(346, 239);
            this.projectBox.Name = "projectBox";
            this.projectBox.Size = new System.Drawing.Size(423, 124);
            this.projectBox.TabIndex = 19;
            this.projectBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Project Works";
            // 
            // AboutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.projectBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bscBox);
            this.Controls.Add(this.mcaBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discriptionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bProgress);
            this.Name = "AboutPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutPage";
            this.Load += new System.EventHandler(this.AboutPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox discriptionBox;
        private System.Windows.Forms.RichTextBox expBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox mcaBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox bscBox;
        private System.Windows.Forms.RichTextBox projectBox;
        private System.Windows.Forms.Label label4;
    }
}