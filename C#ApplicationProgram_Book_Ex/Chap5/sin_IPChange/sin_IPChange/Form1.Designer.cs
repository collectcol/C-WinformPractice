namespace sin_IPChange
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
            this.lblIp = new System.Windows.Forms.Label();
            this.lblSubnet = new System.Windows.Forms.Label();
            this.lblGatway = new System.Windows.Forms.Label();
            this.txtAfterIP = new System.Windows.Forms.TextBox();
            this.txtAfterSubnet = new System.Windows.Forms.TextBox();
            this.txtAfterGateway = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDHCP = new System.Windows.Forms.Button();
            this.gbBefore = new System.Windows.Forms.GroupBox();
            this.txtBeforeIPKey = new System.Windows.Forms.TextBox();
            this.lblBeforeIPKey = new System.Windows.Forms.Label();
            this.lblBeforeIP = new System.Windows.Forms.Label();
            this.lblBeforeSubnet = new System.Windows.Forms.Label();
            this.lblBeforeGateway = new System.Windows.Forms.Label();
            this.txtBeforeGateway = new System.Windows.Forms.TextBox();
            this.txtBeforeIP = new System.Windows.Forms.TextBox();
            this.txtBeforeSubnet = new System.Windows.Forms.TextBox();
            this.gbAfter = new System.Windows.Forms.GroupBox();
            this.txtAfterIPKey = new System.Windows.Forms.TextBox();
            this.lblIPKey = new System.Windows.Forms.Label();
            this.lblChooseIPKey = new System.Windows.Forms.Label();
            this.cmbChooseIPKey = new System.Windows.Forms.ComboBox();
            this.gbBefore.SuspendLayout();
            this.gbAfter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(20, 26);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(49, 12);
            this.lblIp.TabIndex = 0;
            this.lblIp.Text = "아이피 :";
            // 
            // lblSubnet
            // 
            this.lblSubnet.AutoSize = true;
            this.lblSubnet.Location = new System.Drawing.Point(20, 58);
            this.lblSubnet.Name = "lblSubnet";
            this.lblSubnet.Size = new System.Drawing.Size(49, 12);
            this.lblSubnet.TabIndex = 1;
            this.lblSubnet.Text = "서브넷 :";
            // 
            // lblGatway
            // 
            this.lblGatway.AutoSize = true;
            this.lblGatway.Location = new System.Drawing.Point(20, 91);
            this.lblGatway.Name = "lblGatway";
            this.lblGatway.Size = new System.Drawing.Size(73, 12);
            this.lblGatway.TabIndex = 2;
            this.lblGatway.Text = "게이트웨이 :";
            // 
            // txtAfterIP
            // 
            this.txtAfterIP.Location = new System.Drawing.Point(106, 23);
            this.txtAfterIP.Name = "txtAfterIP";
            this.txtAfterIP.Size = new System.Drawing.Size(252, 21);
            this.txtAfterIP.TabIndex = 0;
            // 
            // txtAfterSubnet
            // 
            this.txtAfterSubnet.Location = new System.Drawing.Point(106, 55);
            this.txtAfterSubnet.Name = "txtAfterSubnet";
            this.txtAfterSubnet.Size = new System.Drawing.Size(252, 21);
            this.txtAfterSubnet.TabIndex = 1;
            // 
            // txtAfterGateway
            // 
            this.txtAfterGateway.Location = new System.Drawing.Point(106, 88);
            this.txtAfterGateway.Name = "txtAfterGateway";
            this.txtAfterGateway.Size = new System.Drawing.Size(252, 21);
            this.txtAfterGateway.TabIndex = 2;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(543, 184);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(80, 21);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "변경";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(629, 184);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 21);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDHCP
            // 
            this.btnDHCP.Location = new System.Drawing.Point(715, 184);
            this.btnDHCP.Name = "btnDHCP";
            this.btnDHCP.Size = new System.Drawing.Size(80, 21);
            this.btnDHCP.TabIndex = 8;
            this.btnDHCP.Text = "자동";
            this.btnDHCP.UseVisualStyleBackColor = true;
            this.btnDHCP.Visible = false;
            this.btnDHCP.Click += new System.EventHandler(this.btnDHCP_Click);
            // 
            // gbBefore
            // 
            this.gbBefore.Controls.Add(this.txtBeforeIPKey);
            this.gbBefore.Controls.Add(this.lblBeforeIPKey);
            this.gbBefore.Controls.Add(this.lblBeforeIP);
            this.gbBefore.Controls.Add(this.lblBeforeSubnet);
            this.gbBefore.Controls.Add(this.lblBeforeGateway);
            this.gbBefore.Controls.Add(this.txtBeforeGateway);
            this.gbBefore.Controls.Add(this.txtBeforeIP);
            this.gbBefore.Controls.Add(this.txtBeforeSubnet);
            this.gbBefore.Location = new System.Drawing.Point(12, 12);
            this.gbBefore.Name = "gbBefore";
            this.gbBefore.Size = new System.Drawing.Size(380, 156);
            this.gbBefore.TabIndex = 9;
            this.gbBefore.TabStop = false;
            this.gbBefore.Text = "현재 사용자 주소";
            // 
            // txtBeforeIPKey
            // 
            this.txtBeforeIPKey.Location = new System.Drawing.Point(104, 120);
            this.txtBeforeIPKey.Name = "txtBeforeIPKey";
            this.txtBeforeIPKey.ReadOnly = true;
            this.txtBeforeIPKey.Size = new System.Drawing.Size(252, 21);
            this.txtBeforeIPKey.TabIndex = 17;
            // 
            // lblBeforeIPKey
            // 
            this.lblBeforeIPKey.AutoSize = true;
            this.lblBeforeIPKey.Location = new System.Drawing.Point(18, 123);
            this.lblBeforeIPKey.Name = "lblBeforeIPKey";
            this.lblBeforeIPKey.Size = new System.Drawing.Size(45, 12);
            this.lblBeforeIPKey.TabIndex = 16;
            this.lblBeforeIPKey.Text = "명  칭 :";
            // 
            // lblBeforeIP
            // 
            this.lblBeforeIP.AutoSize = true;
            this.lblBeforeIP.Location = new System.Drawing.Point(18, 26);
            this.lblBeforeIP.Name = "lblBeforeIP";
            this.lblBeforeIP.Size = new System.Drawing.Size(49, 12);
            this.lblBeforeIP.TabIndex = 10;
            this.lblBeforeIP.Text = "아이피 :";
            // 
            // lblBeforeSubnet
            // 
            this.lblBeforeSubnet.AutoSize = true;
            this.lblBeforeSubnet.Location = new System.Drawing.Point(18, 58);
            this.lblBeforeSubnet.Name = "lblBeforeSubnet";
            this.lblBeforeSubnet.Size = new System.Drawing.Size(49, 12);
            this.lblBeforeSubnet.TabIndex = 11;
            this.lblBeforeSubnet.Text = "서브넷 :";
            // 
            // lblBeforeGateway
            // 
            this.lblBeforeGateway.AutoSize = true;
            this.lblBeforeGateway.Location = new System.Drawing.Point(18, 91);
            this.lblBeforeGateway.Name = "lblBeforeGateway";
            this.lblBeforeGateway.Size = new System.Drawing.Size(73, 12);
            this.lblBeforeGateway.TabIndex = 12;
            this.lblBeforeGateway.Text = "게이트웨이 :";
            // 
            // txtBeforeGateway
            // 
            this.txtBeforeGateway.Location = new System.Drawing.Point(104, 88);
            this.txtBeforeGateway.Name = "txtBeforeGateway";
            this.txtBeforeGateway.ReadOnly = true;
            this.txtBeforeGateway.Size = new System.Drawing.Size(252, 21);
            this.txtBeforeGateway.TabIndex = 15;
            // 
            // txtBeforeIP
            // 
            this.txtBeforeIP.Location = new System.Drawing.Point(104, 23);
            this.txtBeforeIP.Name = "txtBeforeIP";
            this.txtBeforeIP.ReadOnly = true;
            this.txtBeforeIP.Size = new System.Drawing.Size(252, 21);
            this.txtBeforeIP.TabIndex = 13;
            // 
            // txtBeforeSubnet
            // 
            this.txtBeforeSubnet.Location = new System.Drawing.Point(104, 55);
            this.txtBeforeSubnet.Name = "txtBeforeSubnet";
            this.txtBeforeSubnet.ReadOnly = true;
            this.txtBeforeSubnet.Size = new System.Drawing.Size(252, 21);
            this.txtBeforeSubnet.TabIndex = 14;
            // 
            // gbAfter
            // 
            this.gbAfter.Controls.Add(this.txtAfterIPKey);
            this.gbAfter.Controls.Add(this.lblIPKey);
            this.gbAfter.Controls.Add(this.lblIp);
            this.gbAfter.Controls.Add(this.lblSubnet);
            this.gbAfter.Controls.Add(this.lblGatway);
            this.gbAfter.Controls.Add(this.txtAfterIP);
            this.gbAfter.Controls.Add(this.txtAfterSubnet);
            this.gbAfter.Controls.Add(this.txtAfterGateway);
            this.gbAfter.Location = new System.Drawing.Point(409, 12);
            this.gbAfter.Name = "gbAfter";
            this.gbAfter.Size = new System.Drawing.Size(384, 156);
            this.gbAfter.TabIndex = 10;
            this.gbAfter.TabStop = false;
            this.gbAfter.Text = "변경할 사용자 주소";
            // 
            // txtAfterIPKey
            // 
            this.txtAfterIPKey.Location = new System.Drawing.Point(106, 120);
            this.txtAfterIPKey.Name = "txtAfterIPKey";
            this.txtAfterIPKey.Size = new System.Drawing.Size(252, 21);
            this.txtAfterIPKey.TabIndex = 3;
            // 
            // lblIPKey
            // 
            this.lblIPKey.AutoSize = true;
            this.lblIPKey.Location = new System.Drawing.Point(20, 123);
            this.lblIPKey.Name = "lblIPKey";
            this.lblIPKey.Size = new System.Drawing.Size(45, 12);
            this.lblIPKey.TabIndex = 17;
            this.lblIPKey.Text = "명  칭 :";
            // 
            // lblChooseIPKey
            // 
            this.lblChooseIPKey.AutoSize = true;
            this.lblChooseIPKey.Location = new System.Drawing.Point(30, 189);
            this.lblChooseIPKey.Name = "lblChooseIPKey";
            this.lblChooseIPKey.Size = new System.Drawing.Size(129, 12);
            this.lblChooseIPKey.TabIndex = 11;
            this.lblChooseIPKey.Text = "저장된 주소 불러오기 :";
            // 
            // cmbChooseIPKey
            // 
            this.cmbChooseIPKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChooseIPKey.FormattingEnabled = true;
            this.cmbChooseIPKey.Location = new System.Drawing.Point(165, 186);
            this.cmbChooseIPKey.Name = "cmbChooseIPKey";
            this.cmbChooseIPKey.Size = new System.Drawing.Size(140, 20);
            this.cmbChooseIPKey.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 220);
            this.Controls.Add(this.cmbChooseIPKey);
            this.Controls.Add(this.lblChooseIPKey);
            this.Controls.Add(this.gbAfter);
            this.Controls.Add(this.gbBefore);
            this.Controls.Add(this.btnDHCP);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP 정보 변경";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbBefore.ResumeLayout(false);
            this.gbBefore.PerformLayout();
            this.gbAfter.ResumeLayout(false);
            this.gbAfter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblSubnet;
        private System.Windows.Forms.Label lblGatway;
        private System.Windows.Forms.TextBox txtAfterIP;
        private System.Windows.Forms.TextBox txtAfterSubnet;
        private System.Windows.Forms.TextBox txtAfterGateway;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDHCP;
        private System.Windows.Forms.GroupBox gbBefore;
        private System.Windows.Forms.Label lblBeforeIP;
        private System.Windows.Forms.Label lblBeforeSubnet;
        private System.Windows.Forms.Label lblBeforeGateway;
        private System.Windows.Forms.TextBox txtBeforeGateway;
        private System.Windows.Forms.TextBox txtBeforeIP;
        private System.Windows.Forms.TextBox txtBeforeSubnet;
        private System.Windows.Forms.GroupBox gbAfter;
        private System.Windows.Forms.Label lblChooseIPKey;
        private System.Windows.Forms.TextBox txtBeforeIPKey;
        private System.Windows.Forms.Label lblBeforeIPKey;
        private System.Windows.Forms.TextBox txtAfterIPKey;
        private System.Windows.Forms.Label lblIPKey;
        private System.Windows.Forms.ComboBox cmbChooseIPKey;
    }
}