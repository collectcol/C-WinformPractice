namespace sin_FileRestore
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
            this.lvRcbFile = new System.Windows.Forms.ListView();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvRcbFile
            // 
            this.lvRcbFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chPath,
            this.chDel});
            this.lvRcbFile.FullRowSelect = true;
            this.lvRcbFile.GridLines = true;
            this.lvRcbFile.HideSelection = false;
            this.lvRcbFile.Location = new System.Drawing.Point(12, 12);
            this.lvRcbFile.Name = "lvRcbFile";
            this.lvRcbFile.Size = new System.Drawing.Size(611, 365);
            this.lvRcbFile.TabIndex = 0;
            this.lvRcbFile.UseCompatibleStateImageBehavior = false;
            this.lvRcbFile.View = System.Windows.Forms.View.Details;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(269, 396);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(114, 28);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "휴지통비우기";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(389, 396);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(114, 28);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "복원";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(509, 396);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 28);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 150;
            // 
            // chPath
            // 
            this.chPath.Text = "원래 위치";
            this.chPath.Width = 260;
            // 
            // chDel
            // 
            this.chDel.Text = "삭제된 날짜";
            this.chDel.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 440);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lvRcbFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "휴지통 복원";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvRcbFile;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPath;
        private System.Windows.Forms.ColumnHeader chDel;
    }
}