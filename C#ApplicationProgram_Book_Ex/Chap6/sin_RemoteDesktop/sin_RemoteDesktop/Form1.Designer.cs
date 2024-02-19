namespace sin_RemoteDesktop
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
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblPixel = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbPixel = new System.Windows.Forms.ComboBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(12, 12);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(527, 69);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 0;
            this.pbBack.TabStop = false;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(12, 101);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(53, 12);
            this.lblIp.TabIndex = 1;
            this.lblIp.Text = "아이피 : ";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(328, 101);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(41, 12);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "포트 : ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(106, 143);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(53, 12);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "아이디 : ";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(316, 143);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(65, 12);
            this.lblPwd.TabIndex = 4;
            this.lblPwd.Text = "비밀번호 : ";
            // 
            // lblPixel
            // 
            this.lblPixel.AutoSize = true;
            this.lblPixel.Location = new System.Drawing.Point(12, 186);
            this.lblPixel.Name = "lblPixel";
            this.lblPixel.Size = new System.Drawing.Size(53, 12);
            this.lblPixel.TabIndex = 5;
            this.lblPixel.Text = "해상도 : ";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(71, 98);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(230, 21);
            this.txtIp.TabIndex = 6;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(375, 98);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(165, 21);
            this.txtPort.TabIndex = 7;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(387, 140);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(153, 21);
            this.txtPwd.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(165, 140);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 21);
            this.txtId.TabIndex = 9;
            // 
            // cbPixel
            // 
            this.cbPixel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPixel.FormattingEnabled = true;
            this.cbPixel.Items.AddRange(new object[] {
            "1024 x 768",
            "1920 x 1080",
            "1280 x 720",
            "1600 x 900"});
            this.cbPixel.Location = new System.Drawing.Point(71, 183);
            this.cbPixel.Name = "cbPixel";
            this.cbPixel.Size = new System.Drawing.Size(206, 20);
            this.cbPixel.TabIndex = 10;
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(318, 183);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(91, 20);
            this.btnConn.TabIndex = 11;
            this.btnConn.Text = "연결";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(431, 183);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(91, 20);
            this.btnCan.TabIndex = 12;
            this.btnCan.Text = "취소";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 215);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.cbPixel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.lblPixel);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.pbBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "원격 데스크톱 연결";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblPixel;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbPixel;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Button btnCan;
    }
}