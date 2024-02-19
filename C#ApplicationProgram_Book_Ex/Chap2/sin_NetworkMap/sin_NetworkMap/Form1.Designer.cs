namespace sin_NetworkMap
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
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.stsBar = new System.Windows.Forms.StatusStrip();
            this.plMap = new System.Windows.Forms.Panel();
            this.tsslblItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsbtnPC = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSVF = new System.Windows.Forms.ToolStripButton();
            this.tsbtnR = new System.Windows.Forms.ToolStripButton();
            this.tsbtnS = new System.Windows.Forms.ToolStripButton();
            this.tsbtnD = new System.Windows.Forms.ToolStripButton();
            this.tsbtnW = new System.Windows.Forms.ToolStripButton();
            this.tsMenu.SuspendLayout();
            this.stsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPC,
            this.tsbtnSVF,
            this.tsbtnR,
            this.tsbtnS,
            this.tsbtnD,
            this.tsbtnW});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(800, 25);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            this.tsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsMenu_ItemClicked);
            // 
            // stsBar
            // 
            this.stsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblItem});
            this.stsBar.Location = new System.Drawing.Point(0, 428);
            this.stsBar.Name = "stsBar";
            this.stsBar.Size = new System.Drawing.Size(800, 22);
            this.stsBar.TabIndex = 1;
            this.stsBar.Text = "statusStrip1";
            // 
            // plMap
            // 
            this.plMap.BackColor = System.Drawing.Color.White;
            this.plMap.Location = new System.Drawing.Point(12, 28);
            this.plMap.Name = "plMap";
            this.plMap.Size = new System.Drawing.Size(776, 397);
            this.plMap.TabIndex = 2;
            // 
            // tsslblItem
            // 
            this.tsslblItem.Name = "tsslblItem";
            this.tsslblItem.Size = new System.Drawing.Size(50, 17);
            this.tsslblItem.Text = "Result : ";
            // 
            // tsbtnPC
            // 
            this.tsbtnPC.Image = global::sin_NetworkMap.Properties.Resources.assignto_32x32;
            this.tsbtnPC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPC.Name = "tsbtnPC";
            this.tsbtnPC.Size = new System.Drawing.Size(65, 22);
            this.tsbtnPC.Tag = "0";
            this.tsbtnPC.Text = "UserPC";
            this.tsbtnPC.ToolTipText = "UserPC";
            // 
            // tsbtnSVF
            // 
            this.tsbtnSVF.Image = global::sin_NetworkMap.Properties.Resources.bocustomer_32x32;
            this.tsbtnSVF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSVF.Name = "tsbtnSVF";
            this.tsbtnSVF.Size = new System.Drawing.Size(78, 22);
            this.tsbtnSVF.Tag = "1";
            this.tsbtnSVF.Text = "FileServer";
            // 
            // tsbtnR
            // 
            this.tsbtnR.Image = global::sin_NetworkMap.Properties.Resources.documentproperties_16x16;
            this.tsbtnR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnR.Name = "tsbtnR";
            this.tsbtnR.Size = new System.Drawing.Size(62, 22);
            this.tsbtnR.Tag = "2";
            this.tsbtnR.Text = "Router";
            // 
            // tsbtnS
            // 
            this.tsbtnS.Image = global::sin_NetworkMap.Properties.Resources.iconsetquarters5_16x16;
            this.tsbtnS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnS.Name = "tsbtnS";
            this.tsbtnS.Size = new System.Drawing.Size(63, 22);
            this.tsbtnS.Tag = "3";
            this.tsbtnS.Text = "Switch";
            // 
            // tsbtnD
            // 
            this.tsbtnD.Image = global::sin_NetworkMap.Properties.Resources.iconsetsigns3_16x16;
            this.tsbtnD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnD.Name = "tsbtnD";
            this.tsbtnD.Size = new System.Drawing.Size(76, 22);
            this.tsbtnD.Tag = "4";
            this.tsbtnD.Text = "DBServer";
            // 
            // tsbtnW
            // 
            this.tsbtnW.Image = global::sin_NetworkMap.Properties.Resources.index_16x16;
            this.tsbtnW.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnW.Name = "tsbtnW";
            this.tsbtnW.Size = new System.Drawing.Size(93, 22);
            this.tsbtnW.Tag = "5";
            this.tsbtnW.Text = "WorkStation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plMap);
            this.Controls.Add(this.stsBar);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "이미지 맵 그리기";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.stsBar.ResumeLayout(false);
            this.stsBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbtnPC;
        private System.Windows.Forms.ToolStripButton tsbtnSVF;
        private System.Windows.Forms.ToolStripButton tsbtnR;
        private System.Windows.Forms.ToolStripButton tsbtnS;
        private System.Windows.Forms.ToolStripButton tsbtnD;
        private System.Windows.Forms.ToolStripButton tsbtnW;
        private System.Windows.Forms.StatusStrip stsBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslblItem;
        private System.Windows.Forms.Panel plMap;
    }
}