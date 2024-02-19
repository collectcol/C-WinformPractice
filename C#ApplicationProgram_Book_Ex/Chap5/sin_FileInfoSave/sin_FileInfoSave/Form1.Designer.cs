namespace sin_FileInfoSave
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
            this.btnPath = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbSave = new System.Windows.Forms.GroupBox();
            this.rbTxt = new System.Windows.Forms.RadioButton();
            this.rbExcel = new System.Windows.Forms.RadioButton();
            this.lvFile = new System.Windows.Forms.ListView();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 41);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(224, 21);
            this.txtPath.TabIndex = 0;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(242, 41);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(134, 21);
            this.btnPath.TabIndex = 1;
            this.btnPath.Text = "File";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(235, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 21);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbSave
            // 
            this.gbSave.Controls.Add(this.rbExcel);
            this.gbSave.Controls.Add(this.btnSave);
            this.gbSave.Controls.Add(this.rbTxt);
            this.gbSave.Location = new System.Drawing.Point(397, 12);
            this.gbSave.Name = "gbSave";
            this.gbSave.Size = new System.Drawing.Size(397, 70);
            this.gbSave.TabIndex = 3;
            this.gbSave.TabStop = false;
            this.gbSave.Text = "파일저장";
            // 
            // rbTxt
            // 
            this.rbTxt.AutoSize = true;
            this.rbTxt.Checked = true;
            this.rbTxt.Location = new System.Drawing.Point(40, 31);
            this.rbTxt.Name = "rbTxt";
            this.rbTxt.Size = new System.Drawing.Size(47, 16);
            this.rbTxt.TabIndex = 4;
            this.rbTxt.TabStop = true;
            this.rbTxt.Text = "TXT";
            this.rbTxt.UseVisualStyleBackColor = true;
            // 
            // rbExcel
            // 
            this.rbExcel.AutoSize = true;
            this.rbExcel.Location = new System.Drawing.Point(125, 31);
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Size = new System.Drawing.Size(63, 16);
            this.rbExcel.TabIndex = 4;
            this.rbExcel.TabStop = true;
            this.rbExcel.Text = "EXCEL";
            this.rbExcel.UseVisualStyleBackColor = true;
            // 
            // lvFile
            // 
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chDate,
            this.chType,
            this.shSize,
            this.chPath});
            this.lvFile.FullRowSelect = true;
            this.lvFile.GridLines = true;
            this.lvFile.HideSelection = false;
            this.lvFile.Location = new System.Drawing.Point(12, 100);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(782, 376);
            this.lvFile.TabIndex = 4;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.Filter = "모든 파일(*.*)|*.*";
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 150;
            // 
            // chDate
            // 
            this.chDate.Text = "수정한 날짜";
            this.chDate.Width = 100;
            // 
            // chType
            // 
            this.chType.Text = "유형";
            this.chType.Width = 100;
            // 
            // shSize
            // 
            this.shSize.Text = "크기";
            this.shSize.Width = 100;
            // 
            // chPath
            // 
            this.chPath.Text = "경로";
            this.chPath.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 488);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.gbSave);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "File Information";
            this.gbSave.ResumeLayout(false);
            this.gbSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbSave;
        private System.Windows.Forms.RadioButton rbExcel;
        private System.Windows.Forms.RadioButton rbTxt;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader shSize;
        private System.Windows.Forms.ColumnHeader chPath;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
    }
}