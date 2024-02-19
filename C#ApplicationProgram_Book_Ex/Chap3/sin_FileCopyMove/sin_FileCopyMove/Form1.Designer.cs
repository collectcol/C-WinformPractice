namespace sin_FileCopyMove
{
    partial class form1
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
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.btnSrc = new System.Windows.Forms.Button();
            this.btnDest = new System.Windows.Forms.Button();
            this.gbBox = new System.Windows.Forms.GroupBox();
            this.rbCopy = new System.Windows.Forms.RadioButton();
            this.rbMove = new System.Windows.Forms.RadioButton();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblSrc = new System.Windows.Forms.Label();
            this.lblDest = new System.Windows.Forms.Label();
            this.lvSrc = new System.Windows.Forms.ListView();
            this.lvDest = new System.Windows.Forms.ListView();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.chFileSrc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileDest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspgrbar = new System.Windows.Forms.ToolStripProgressBar();
            this.gbBox.SuspendLayout();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(12, 12);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.ReadOnly = true;
            this.txtSrc.Size = new System.Drawing.Size(460, 21);
            this.txtSrc.TabIndex = 0;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(12, 46);
            this.txtDest.Name = "txtDest";
            this.txtDest.ReadOnly = true;
            this.txtDest.Size = new System.Drawing.Size(460, 21);
            this.txtDest.TabIndex = 1;
            // 
            // btnSrc
            // 
            this.btnSrc.Location = new System.Drawing.Point(493, 12);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(129, 21);
            this.btnSrc.TabIndex = 2;
            this.btnSrc.Text = "FileSrc";
            this.btnSrc.UseVisualStyleBackColor = true;
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // btnDest
            // 
            this.btnDest.Location = new System.Drawing.Point(493, 46);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(129, 21);
            this.btnDest.TabIndex = 3;
            this.btnDest.Text = "FileDest";
            this.btnDest.UseVisualStyleBackColor = true;
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // gbBox
            // 
            this.gbBox.Controls.Add(this.rbMove);
            this.gbBox.Controls.Add(this.rbCopy);
            this.gbBox.Location = new System.Drawing.Point(645, 12);
            this.gbBox.Name = "gbBox";
            this.gbBox.Size = new System.Drawing.Size(198, 55);
            this.gbBox.TabIndex = 4;
            this.gbBox.TabStop = false;
            this.gbBox.Text = "Choose";
            // 
            // rbCopy
            // 
            this.rbCopy.AutoSize = true;
            this.rbCopy.Checked = true;
            this.rbCopy.Location = new System.Drawing.Point(16, 23);
            this.rbCopy.Name = "rbCopy";
            this.rbCopy.Size = new System.Drawing.Size(73, 16);
            this.rbCopy.TabIndex = 5;
            this.rbCopy.TabStop = true;
            this.rbCopy.Text = "FileCopy";
            this.rbCopy.UseVisualStyleBackColor = true;
            // 
            // rbMove
            // 
            this.rbMove.AutoSize = true;
            this.rbMove.Location = new System.Drawing.Point(114, 23);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(74, 16);
            this.rbMove.TabIndex = 6;
            this.rbMove.Text = "FileMove";
            this.rbMove.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(945, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(161, 55);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblSrc
            // 
            this.lblSrc.AutoSize = true;
            this.lblSrc.Location = new System.Drawing.Point(12, 93);
            this.lblSrc.Name = "lblSrc";
            this.lblSrc.Size = new System.Drawing.Size(29, 12);
            this.lblSrc.TabIndex = 6;
            this.lblSrc.Text = "대상";
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Location = new System.Drawing.Point(694, 93);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(29, 12);
            this.lblDest.TabIndex = 7;
            this.lblDest.Text = "결과";
            // 
            // lvSrc
            // 
            this.lvSrc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileSrc});
            this.lvSrc.GridLines = true;
            this.lvSrc.HideSelection = false;
            this.lvSrc.Location = new System.Drawing.Point(14, 122);
            this.lvSrc.Name = "lvSrc";
            this.lvSrc.Size = new System.Drawing.Size(531, 488);
            this.lvSrc.TabIndex = 8;
            this.lvSrc.UseCompatibleStateImageBehavior = false;
            this.lvSrc.View = System.Windows.Forms.View.Details;
            // 
            // lvDest
            // 
            this.lvDest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileDest});
            this.lvDest.GridLines = true;
            this.lvDest.HideSelection = false;
            this.lvDest.Location = new System.Drawing.Point(574, 122);
            this.lvDest.Name = "lvDest";
            this.lvDest.Size = new System.Drawing.Size(532, 488);
            this.lvDest.TabIndex = 9;
            this.lvDest.UseCompatibleStateImageBehavior = false;
            this.lvDest.View = System.Windows.Forms.View.Details;
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslbl,
            this.tsslblStatus,
            this.tspgrbar});
            this.ssBar.Location = new System.Drawing.Point(0, 626);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(1120, 22);
            this.ssBar.TabIndex = 10;
            this.ssBar.Text = "statusStrip1";
            // 
            // chFileSrc
            // 
            this.chFileSrc.Text = "파일";
            this.chFileSrc.Width = 474;
            // 
            // chFileDest
            // 
            this.chFileDest.Text = "파일";
            this.chFileDest.Width = 475;
            // 
            // tsslbl
            // 
            this.tsslbl.Name = "tsslbl";
            this.tsslbl.Size = new System.Drawing.Size(66, 17);
            this.tsslbl.Text = "진행사항 : ";
            // 
            // tsslblStatus
            // 
            this.tsslblStatus.Name = "tsslblStatus";
            this.tsslblStatus.Size = new System.Drawing.Size(28, 17);
            this.tsslblStatus.Text = "0 %";
            // 
            // tspgrbar
            // 
            this.tspgrbar.Name = "tspgrbar";
            this.tspgrbar.Size = new System.Drawing.Size(100, 16);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 648);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.lvDest);
            this.Controls.Add(this.lvSrc);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.lblSrc);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.gbBox);
            this.Controls.Add(this.btnDest);
            this.Controls.Add(this.btnSrc);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtSrc);
            this.MaximizeBox = false;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Copy & Move";
            this.gbBox.ResumeLayout(false);
            this.gbBox.PerformLayout();
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.Button btnDest;
        private System.Windows.Forms.GroupBox gbBox;
        private System.Windows.Forms.RadioButton rbMove;
        private System.Windows.Forms.RadioButton rbCopy;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblSrc;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.ListView lvSrc;
        private System.Windows.Forms.ColumnHeader chFileSrc;
        private System.Windows.Forms.ListView lvDest;
        private System.Windows.Forms.ColumnHeader chFileDest;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslbl;
        private System.Windows.Forms.ToolStripStatusLabel tsslblStatus;
        private System.Windows.Forms.ToolStripProgressBar tspgrbar;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
    }
}