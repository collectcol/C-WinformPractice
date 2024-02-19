namespace sin_FileWriter
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
            this.txtSave = new System.Windows.Forms.TextBox();
            this.btnLineRead = new System.Windows.Forms.Button();
            this.btnLineSave = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.sfdFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(12, 72);
            this.txtSave.Multiline = true;
            this.txtSave.Name = "txtSave";
            this.txtSave.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSave.Size = new System.Drawing.Size(776, 360);
            this.txtSave.TabIndex = 10;
            // 
            // btnLineRead
            // 
            this.btnLineRead.Location = new System.Drawing.Point(675, 45);
            this.btnLineRead.Name = "btnLineRead";
            this.btnLineRead.Size = new System.Drawing.Size(113, 21);
            this.btnLineRead.TabIndex = 9;
            this.btnLineRead.Text = "라인읽기";
            this.btnLineRead.UseVisualStyleBackColor = true;
            this.btnLineRead.Click += new System.EventHandler(this.btnLineRead_Click);
            // 
            // btnLineSave
            // 
            this.btnLineSave.Location = new System.Drawing.Point(556, 45);
            this.btnLineSave.Name = "btnLineSave";
            this.btnLineSave.Size = new System.Drawing.Size(113, 21);
            this.btnLineSave.TabIndex = 8;
            this.btnLineSave.Text = "전체저장";
            this.btnLineSave.UseVisualStyleBackColor = true;
            this.btnLineSave.Click += new System.EventHandler(this.btnLineSave_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(675, 18);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(113, 21);
            this.btnFile.TabIndex = 7;
            this.btnFile.Text = "파일";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 18);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(657, 21);
            this.txtPath.TabIndex = 6;
            // 
            // sfdFile
            // 
            this.sfdFile.FileName = "sfdFile";
            this.sfdFile.Filter = "텍스트 파일(*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.btnLineRead);
            this.Controls.Add(this.btnLineSave);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "파일 쓰기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Button btnLineRead;
        private System.Windows.Forms.Button btnLineSave;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.OpenFileDialog sfdFile;
    }
}