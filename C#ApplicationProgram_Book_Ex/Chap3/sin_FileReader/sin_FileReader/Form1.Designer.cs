namespace sin_FileReader
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnAllRead = new System.Windows.Forms.Button();
            this.btnLineRead = new System.Windows.Forms.Button();
            this.txtView = new System.Windows.Forms.TextBox();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(657, 21);
            this.txtPath.TabIndex = 0;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(675, 12);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(113, 21);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "파일";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnAllRead
            // 
            this.btnAllRead.Location = new System.Drawing.Point(556, 39);
            this.btnAllRead.Name = "btnAllRead";
            this.btnAllRead.Size = new System.Drawing.Size(113, 21);
            this.btnAllRead.TabIndex = 3;
            this.btnAllRead.Text = "전체읽기";
            this.btnAllRead.UseVisualStyleBackColor = true;
            this.btnAllRead.Click += new System.EventHandler(this.btnAllRead_Click);
            // 
            // btnLineRead
            // 
            this.btnLineRead.Location = new System.Drawing.Point(675, 39);
            this.btnLineRead.Name = "btnLineRead";
            this.btnLineRead.Size = new System.Drawing.Size(113, 21);
            this.btnLineRead.TabIndex = 4;
            this.btnLineRead.Text = "라인읽기";
            this.btnLineRead.UseVisualStyleBackColor = true;
            this.btnLineRead.Click += new System.EventHandler(this.btnLineRead_Click);
            // 
            // txtView
            // 
            this.txtView.Location = new System.Drawing.Point(12, 66);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtView.Size = new System.Drawing.Size(776, 360);
            this.txtView.TabIndex = 5;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.Filter = "텍스트 파일 (*.txt)|*.txt| 모든파일 (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.btnLineRead);
            this.Controls.Add(this.btnAllRead);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "파일 읽기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnAllRead;
        private System.Windows.Forms.Button btnLineRead;
        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}