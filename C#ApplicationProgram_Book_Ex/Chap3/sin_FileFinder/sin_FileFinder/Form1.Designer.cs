namespace sin_FileFinder
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
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.gbOption1 = new System.Windows.Forms.GroupBox();
            this.gbOption2 = new System.Windows.Forms.GroupBox();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnHidden = new System.Windows.Forms.RadioButton();
            this.rbtnFile = new System.Windows.Forms.RadioButton();
            this.rbtnDire = new System.Windows.Forms.RadioButton();
            this.lvFile = new System.Windows.Forms.ListView();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.chFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStop = new System.Windows.Forms.Button();
            this.gbOption1.SuspendLayout();
            this.gbOption2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 9);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(41, 12);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "경로 : ";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(59, 6);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(388, 21);
            this.txtPath.TabIndex = 1;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(453, 6);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(99, 21);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "경로";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // gbOption1
            // 
            this.gbOption1.Controls.Add(this.rbtnHidden);
            this.gbOption1.Controls.Add(this.rbtnAll);
            this.gbOption1.Location = new System.Drawing.Point(14, 45);
            this.gbOption1.Name = "gbOption1";
            this.gbOption1.Size = new System.Drawing.Size(290, 48);
            this.gbOption1.TabIndex = 3;
            this.gbOption1.TabStop = false;
            this.gbOption1.Text = "< 선택 1 >";
            // 
            // gbOption2
            // 
            this.gbOption2.Controls.Add(this.rbtnDire);
            this.gbOption2.Controls.Add(this.rbtnFile);
            this.gbOption2.Location = new System.Drawing.Point(341, 45);
            this.gbOption2.Name = "gbOption2";
            this.gbOption2.Size = new System.Drawing.Size(290, 48);
            this.gbOption2.TabIndex = 4;
            this.gbOption2.TabStop = false;
            this.gbOption2.Text = "< 선택 2 >";
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Location = new System.Drawing.Point(6, 20);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(37, 16);
            this.rbtnAll.TabIndex = 5;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // rbtnHidden
            // 
            this.rbtnHidden.AutoSize = true;
            this.rbtnHidden.Location = new System.Drawing.Point(145, 20);
            this.rbtnHidden.Name = "rbtnHidden";
            this.rbtnHidden.Size = new System.Drawing.Size(62, 16);
            this.rbtnHidden.TabIndex = 6;
            this.rbtnHidden.Text = "Hidden";
            this.rbtnHidden.UseVisualStyleBackColor = true;
            this.rbtnHidden.CheckedChanged += new System.EventHandler(this.rbtnHidden_CheckedChanged);
            // 
            // rbtnFile
            // 
            this.rbtnFile.AutoSize = true;
            this.rbtnFile.Checked = true;
            this.rbtnFile.Location = new System.Drawing.Point(6, 20);
            this.rbtnFile.Name = "rbtnFile";
            this.rbtnFile.Size = new System.Drawing.Size(47, 16);
            this.rbtnFile.TabIndex = 6;
            this.rbtnFile.TabStop = true;
            this.rbtnFile.Text = "파일";
            this.rbtnFile.UseVisualStyleBackColor = true;
            this.rbtnFile.CheckedChanged += new System.EventHandler(this.rbtnFile_CheckedChanged);
            // 
            // rbtnDire
            // 
            this.rbtnDire.AutoSize = true;
            this.rbtnDire.Location = new System.Drawing.Point(145, 20);
            this.rbtnDire.Name = "rbtnDire";
            this.rbtnDire.Size = new System.Drawing.Size(71, 16);
            this.rbtnDire.TabIndex = 6;
            this.rbtnDire.Text = "디렉터리";
            this.rbtnDire.UseVisualStyleBackColor = true;
            this.rbtnDire.CheckedChanged += new System.EventHandler(this.rbtnDire_CheckedChanged);
            // 
            // lvFile
            // 
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFilePath,
            this.chFileName,
            this.chFileTime,
            this.chFileSize});
            this.lvFile.GridLines = true;
            this.lvFile.HideSelection = false;
            this.lvFile.Location = new System.Drawing.Point(14, 99);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(1012, 339);
            this.lvFile.TabIndex = 5;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            // 
            // chFilePath
            // 
            this.chFilePath.Text = "파일 경로";
            this.chFilePath.Width = 400;
            // 
            // chFileName
            // 
            this.chFileName.Text = "파일 이름";
            this.chFileName.Width = 300;
            // 
            // chFileTime
            // 
            this.chFileTime.Text = "생성일";
            this.chFileTime.Width = 150;
            // 
            // chFileSize
            // 
            this.chFileSize.Text = "사이즈";
            this.chFileSize.Width = 150;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(558, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(99, 21);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "중지";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.gbOption2);
            this.Controls.Add(this.gbOption1);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Find File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOption1.ResumeLayout(false);
            this.gbOption1.PerformLayout();
            this.gbOption2.ResumeLayout(false);
            this.gbOption2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.GroupBox gbOption1;
        private System.Windows.Forms.RadioButton rbtnHidden;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.GroupBox gbOption2;
        private System.Windows.Forms.RadioButton rbtnDire;
        private System.Windows.Forms.RadioButton rbtnFile;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.ColumnHeader chFilePath;
        private System.Windows.Forms.ColumnHeader chFileName;
        private System.Windows.Forms.ColumnHeader chFileTime;
        private System.Windows.Forms.ColumnHeader chFileSize;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.Button btnStop;
    }
}