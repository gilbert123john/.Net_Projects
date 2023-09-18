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
            this.SuspendLayout();
            // 
            // bProgress
            // 
            this.bProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProgress.Location = new System.Drawing.Point(31, 384);
            this.bProgress.Name = "bProgress";
            this.bProgress.Size = new System.Drawing.Size(156, 38);
            this.bProgress.TabIndex = 7;
            this.bProgress.Text = "View Progress";
            this.bProgress.UseVisualStyleBackColor = true;
            this.bProgress.Click += new System.EventHandler(this.bProgress_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Discription";
            // 
            // discriptionBox
            // 
            this.discriptionBox.Location = new System.Drawing.Point(234, 75);
            this.discriptionBox.Name = "discriptionBox";
            this.discriptionBox.Size = new System.Drawing.Size(455, 124);
            this.discriptionBox.TabIndex = 12;
            this.discriptionBox.Text = "";
            // 
            // AboutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}