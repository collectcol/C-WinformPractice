namespace sin_WifiScanner
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
            this.lvAP = new System.Windows.Forms.ListView();
            this.chSSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chChanel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAlgorithm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAuth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvAP
            // 
            this.lvAP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSSID,
            this.chQuality,
            this.chEnabled,
            this.chChanel,
            this.chAlgorithm,
            this.chAuth,
            this.chMAC});
            this.lvAP.GridLines = true;
            this.lvAP.HideSelection = false;
            this.lvAP.Location = new System.Drawing.Point(12, 12);
            this.lvAP.Name = "lvAP";
            this.lvAP.Size = new System.Drawing.Size(657, 647);
            this.lvAP.TabIndex = 0;
            this.lvAP.UseCompatibleStateImageBehavior = false;
            this.lvAP.View = System.Windows.Forms.View.Details;
            // 
            // chSSID
            // 
            this.chSSID.Text = "이름";
            this.chSSID.Width = 100;
            // 
            // chQuality
            // 
            this.chQuality.Text = "신호강도";
            // 
            // chEnabled
            // 
            this.chEnabled.Text = "암호화";
            // 
            // chChanel
            // 
            this.chChanel.Text = "채널";
            // 
            // chAlgorithm
            // 
            this.chAlgorithm.Text = "암호방식";
            // 
            // chAuth
            // 
            this.chAuth.Text = "인증방식";
            this.chAuth.Width = 100;
            // 
            // chMAC
            // 
            this.chMAC.Text = "MAC";
            this.chMAC.Width = 170;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 671);
            this.Controls.Add(this.lvAP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "와이파이 스캐너";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAP;
        private System.Windows.Forms.ColumnHeader chSSID;
        private System.Windows.Forms.ColumnHeader chQuality;
        private System.Windows.Forms.ColumnHeader chEnabled;
        private System.Windows.Forms.ColumnHeader chChanel;
        private System.Windows.Forms.ColumnHeader chAlgorithm;
        private System.Windows.Forms.ColumnHeader chAuth;
        private System.Windows.Forms.ColumnHeader chMAC;
    }
}