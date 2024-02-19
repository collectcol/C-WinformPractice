namespace sin_Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tsBar = new System.Windows.Forms.ToolStrip();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.plOption = new System.Windows.Forms.Panel();
            this.plGroup = new System.Windows.Forms.Panel();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.cbServer = new System.Windows.Forms.CheckBox();
            this.tsddbtnOption = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiOption = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnConn = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDisconn = new System.Windows.Forms.ToolStripButton();
            this.tsslblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsBar.SuspendLayout();
            this.ssBar.SuspendLayout();
            this.plOption.SuspendLayout();
            this.plGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBar
            // 
            this.tsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbtnOption,
            this.tsbtnConn,
            this.tsbtnDisconn});
            this.tsBar.Location = new System.Drawing.Point(0, 0);
            this.tsBar.Name = "tsBar";
            this.tsBar.Size = new System.Drawing.Size(391, 25);
            this.tsBar.TabIndex = 0;
            this.tsBar.Text = "toolStrip1";
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblTime});
            this.ssBar.Location = new System.Drawing.Point(0, 512);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(391, 22);
            this.ssBar.TabIndex = 1;
            this.ssBar.Text = "statusStrip1";
            // 
            // rtbText
            // 
            this.rtbText.BackColor = System.Drawing.Color.White;
            this.rtbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbText.Location = new System.Drawing.Point(0, 25);
            this.rtbText.Name = "rtbText";
            this.rtbText.ReadOnly = true;
            this.rtbText.Size = new System.Drawing.Size(391, 408);
            this.rtbText.TabIndex = 2;
            this.rtbText.TabStop = false;
            this.rtbText.Text = "";
            // 
            // plOption
            // 
            this.plOption.BackColor = System.Drawing.Color.AliceBlue;
            this.plOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plOption.Controls.Add(this.cbServer);
            this.plOption.Controls.Add(this.btnClose);
            this.plOption.Controls.Add(this.btnSave);
            this.plOption.Controls.Add(this.txtPort);
            this.plOption.Controls.Add(this.txtId);
            this.plOption.Controls.Add(this.txtIp);
            this.plOption.Controls.Add(this.lblPort);
            this.plOption.Controls.Add(this.lblId);
            this.plOption.Controls.Add(this.lblIp);
            this.plOption.Location = new System.Drawing.Point(67, 112);
            this.plOption.Name = "plOption";
            this.plOption.Size = new System.Drawing.Size(255, 213);
            this.plOption.TabIndex = 3;
            this.plOption.Visible = false;
            // 
            // plGroup
            // 
            this.plGroup.BackColor = System.Drawing.Color.RoyalBlue;
            this.plGroup.Controls.Add(this.btnSend);
            this.plGroup.Controls.Add(this.txtMessage);
            this.plGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plGroup.Location = new System.Drawing.Point(0, 433);
            this.plGroup.Name = "plGroup";
            this.plGroup.Size = new System.Drawing.Size(391, 79);
            this.plGroup.TabIndex = 4;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(26, 22);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(28, 12);
            this.lblIp.TabIndex = 0;
            this.lblIp.Text = "IP : ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(26, 62);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 12);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID : ";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(26, 102);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(46, 12);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "PORT :";
            // 
            // txtIp
            // 
            this.txtIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIp.Location = new System.Drawing.Point(79, 19);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(131, 21);
            this.txtIp.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Location = new System.Drawing.Point(79, 62);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(131, 21);
            this.txtId.TabIndex = 4;
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Location = new System.Drawing.Point(79, 100);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(131, 21);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "62000";
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Enabled = false;
            this.txtMessage.Location = new System.Drawing.Point(12, 15);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(285, 52);
            this.txtMessage.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(28, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "설정";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(145, 167);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 24);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.Enabled = false;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(303, 15);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 52);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // cbServer
            // 
            this.cbServer.AutoSize = true;
            this.cbServer.Location = new System.Drawing.Point(28, 136);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(72, 16);
            this.cbServer.TabIndex = 8;
            this.cbServer.Text = "서버실행";
            this.cbServer.UseVisualStyleBackColor = true;
            this.cbServer.CheckedChanged += new System.EventHandler(this.cbServer_CheckedChanged);
            // 
            // tsddbtnOption
            // 
            this.tsddbtnOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbtnOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOption,
            this.tsmiExit});
            this.tsddbtnOption.Image = ((System.Drawing.Image)(resources.GetObject("tsddbtnOption.Image")));
            this.tsddbtnOption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtnOption.Name = "tsddbtnOption";
            this.tsddbtnOption.Size = new System.Drawing.Size(97, 22);
            this.tsddbtnOption.Text = "1 : 1 환경설정";
            // 
            // tsmiOption
            // 
            this.tsmiOption.Name = "tsmiOption";
            this.tsmiOption.Size = new System.Drawing.Size(180, 22);
            this.tsmiOption.Text = "설정";
            this.tsmiOption.Click += new System.EventHandler(this.tsmiOption_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "닫기";
            // 
            // tsbtnConn
            // 
            this.tsbtnConn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnConn.Enabled = false;
            this.tsbtnConn.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnConn.Image")));
            this.tsbtnConn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConn.Name = "tsbtnConn";
            this.tsbtnConn.Size = new System.Drawing.Size(35, 22);
            this.tsbtnConn.Text = "연결";
            this.tsbtnConn.Click += new System.EventHandler(this.tsbtnConn_Click);
            // 
            // tsbtnDisconn
            // 
            this.tsbtnDisconn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnDisconn.Enabled = false;
            this.tsbtnDisconn.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDisconn.Image")));
            this.tsbtnDisconn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDisconn.Name = "tsbtnDisconn";
            this.tsbtnDisconn.Size = new System.Drawing.Size(35, 22);
            this.tsbtnDisconn.Text = "끊기";
            // 
            // tsslblTime
            // 
            this.tsslblTime.Name = "tsslblTime";
            this.tsslblTime.Size = new System.Drawing.Size(127, 17);
            this.tsslblTime.Text = "메시지 받은 시간 출력";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 534);
            this.Controls.Add(this.plGroup);
            this.Controls.Add(this.plOption);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.tsBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "1 : 1 채팅";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsBar.ResumeLayout(false);
            this.tsBar.PerformLayout();
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.plOption.ResumeLayout(false);
            this.plOption.PerformLayout();
            this.plGroup.ResumeLayout(false);
            this.plGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBar;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Panel plOption;
        private System.Windows.Forms.CheckBox cbServer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Panel plGroup;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtnOption;
        private System.Windows.Forms.ToolStripMenuItem tsmiOption;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripButton tsbtnConn;
        private System.Windows.Forms.ToolStripButton tsbtnDisconn;
        private System.Windows.Forms.ToolStripStatusLabel tsslblTime;
    }
}