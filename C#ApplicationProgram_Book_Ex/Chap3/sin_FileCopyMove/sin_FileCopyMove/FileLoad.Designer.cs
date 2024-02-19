namespace sin_FileCopyMove
{
    partial class FileLoad
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
            this.lblCopy = new System.Windows.Forms.Label();
            this.pgbCopy = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Location = new System.Drawing.Point(26, 25);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(61, 12);
            this.lblCopy.TabIndex = 0;
            this.lblCopy.Text = "복 사 : 0%";
            // 
            // pgbCopy
            // 
            this.pgbCopy.Location = new System.Drawing.Point(28, 50);
            this.pgbCopy.Name = "pgbCopy";
            this.pgbCopy.Size = new System.Drawing.Size(585, 47);
            this.pgbCopy.Step = 1;
            this.pgbCopy.TabIndex = 1;
            // 
            // FileLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 124);
            this.Controls.Add(this.pgbCopy);
            this.Controls.Add(this.lblCopy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileLoad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "파일 복사";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileLoad_FormClosing);
            this.Load += new System.EventHandler(this.FileLoad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.ProgressBar pgbCopy;
    }
}