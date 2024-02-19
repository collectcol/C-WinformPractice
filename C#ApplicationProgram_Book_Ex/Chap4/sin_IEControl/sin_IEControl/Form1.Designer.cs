namespace sin_IEControl
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
            this.bgConfig = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtProxy = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnProxy = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.stsBar = new System.Windows.Forms.StatusStrip();
            this.tsslbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgConfig.SuspendLayout();
            this.stsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgConfig
            // 
            this.bgConfig.Controls.Add(this.btnProxy);
            this.bgConfig.Controls.Add(this.txtPort);
            this.bgConfig.Controls.Add(this.txtProxy);
            this.bgConfig.Controls.Add(this.lblPort);
            this.bgConfig.Controls.Add(this.label1);
            this.bgConfig.Location = new System.Drawing.Point(22, 24);
            this.bgConfig.Name = "bgConfig";
            this.bgConfig.Size = new System.Drawing.Size(714, 113);
            this.bgConfig.TabIndex = 0;
            this.bgConfig.TabStop = false;
            this.bgConfig.Text = "Proxy Config";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proxy IP";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(348, 53);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(27, 12);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Prot";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(20, 182);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(36, 12);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL :";
            // 
            // txtProxy
            // 
            this.txtProxy.Location = new System.Drawing.Point(89, 50);
            this.txtProxy.Name = "txtProxy";
            this.txtProxy.Size = new System.Drawing.Size(236, 21);
            this.txtProxy.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(390, 50);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(114, 21);
            this.txtPort.TabIndex = 3;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(62, 179);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(464, 21);
            this.txtUrl.TabIndex = 4;
            // 
            // btnProxy
            // 
            this.btnProxy.Location = new System.Drawing.Point(532, 50);
            this.btnProxy.Name = "btnProxy";
            this.btnProxy.Size = new System.Drawing.Size(140, 21);
            this.btnProxy.TabIndex = 5;
            this.btnProxy.Text = "Proxy ON";
            this.btnProxy.UseVisualStyleBackColor = true;
            this.btnProxy.Click += new System.EventHandler(this.btnProxy_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(532, 179);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(98, 21);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "URL RUN";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(636, 179);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 21);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // stsBar
            // 
            this.stsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslbStatus});
            this.stsBar.Location = new System.Drawing.Point(0, 230);
            this.stsBar.Name = "stsBar";
            this.stsBar.Size = new System.Drawing.Size(759, 22);
            this.stsBar.TabIndex = 8;
            this.stsBar.Text = "statusStrip1";
            // 
            // tsslbStatus
            // 
            this.tsslbStatus.Name = "tsslbStatus";
            this.tsslbStatus.Size = new System.Drawing.Size(51, 17);
            this.tsslbStatus.Text = "Status : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 252);
            this.Controls.Add(this.stsBar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.bgConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IE Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bgConfig.ResumeLayout(false);
            this.bgConfig.PerformLayout();
            this.stsBar.ResumeLayout(false);
            this.stsBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox bgConfig;
        private System.Windows.Forms.Button btnProxy;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtProxy;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.StatusStrip stsBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslbStatus;
    }
}