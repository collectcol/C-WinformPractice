namespace sin_MemoryReaderWriter
{
    partial class Form1
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
            this.txtOpenPath = new System.Windows.Forms.TextBox();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnMemLoad = new System.Windows.Forms.Button();
            this.btnFileSave = new System.Windows.Forms.Button();
            this.lblPer = new System.Windows.Forms.Label();
            this.pgbLoad = new System.Windows.Forms.ProgressBar();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtOpenPath
            // 
            this.txtOpenPath.Location = new System.Drawing.Point(12, 12);
            this.txtOpenPath.Name = "txtOpenPath";
            this.txtOpenPath.ReadOnly = true;
            this.txtOpenPath.Size = new System.Drawing.Size(634, 21);
            this.txtOpenPath.TabIndex = 0;
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.Location = new System.Drawing.Point(662, 12);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(126, 21);
            this.btnOpenPath.TabIndex = 2;
            this.btnOpenPath.Text = "파일 경로";
            this.btnOpenPath.UseVisualStyleBackColor = true;
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(662, 51);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(126, 21);
            this.btnSavePath.TabIndex = 3;
            this.btnSavePath.Text = "저장 경로";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(12, 51);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.ReadOnly = true;
            this.txtSavePath.Size = new System.Drawing.Size(634, 21);
            this.txtSavePath.TabIndex = 4;
            // 
            // btnMemLoad
            // 
            this.btnMemLoad.Location = new System.Drawing.Point(520, 107);
            this.btnMemLoad.Name = "btnMemLoad";
            this.btnMemLoad.Size = new System.Drawing.Size(126, 21);
            this.btnMemLoad.TabIndex = 5;
            this.btnMemLoad.Text = "파일 -> 메모리";
            this.btnMemLoad.UseVisualStyleBackColor = true;
            this.btnMemLoad.Click += new System.EventHandler(this.btnMemLoad_Click);
            // 
            // btnFileSave
            // 
            this.btnFileSave.Location = new System.Drawing.Point(662, 107);
            this.btnFileSave.Name = "btnFileSave";
            this.btnFileSave.Size = new System.Drawing.Size(126, 21);
            this.btnFileSave.TabIndex = 6;
            this.btnFileSave.Text = "메모리 -> 파일";
            this.btnFileSave.UseVisualStyleBackColor = true;
            this.btnFileSave.Click += new System.EventHandler(this.btnFileSave_Click);
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Location = new System.Drawing.Point(12, 178);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(25, 12);
            this.lblPer.TabIndex = 7;
            this.lblPer.Text = "0 %";
            // 
            // pgbLoad
            // 
            this.pgbLoad.Location = new System.Drawing.Point(55, 166);
            this.pgbLoad.Name = "pgbLoad";
            this.pgbLoad.Size = new System.Drawing.Size(733, 36);
            this.pgbLoad.Step = 1;
            this.pgbLoad.TabIndex = 8;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.Filter = "모든 파일(*.*)|*.*";
            // 
            // sfdFile
            // 
            this.sfdFile.Filter = "모든 파일(*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 214);
            this.Controls.Add(this.pgbLoad);
            this.Controls.Add(this.lblPer);
            this.Controls.Add(this.btnFileSave);
            this.Controls.Add(this.btnMemLoad);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.btnSavePath);
            this.Controls.Add(this.btnOpenPath);
            this.Controls.Add(this.txtOpenPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "메모리 읽기 쓰기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpenPath;
        private System.Windows.Forms.Button btnOpenPath;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnMemLoad;
        private System.Windows.Forms.Button btnFileSave;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.ProgressBar pgbLoad;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
    }
}