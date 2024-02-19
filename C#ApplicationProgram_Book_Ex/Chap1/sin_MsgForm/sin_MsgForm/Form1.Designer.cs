namespace sin_MsgForm
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
            this.plBack = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.plBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // plBack
            // 
            this.plBack.BackColor = System.Drawing.Color.LightBlue;
            this.plBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plBack.Controls.Add(this.picClose);
            this.plBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plBack.Location = new System.Drawing.Point(0, 0);
            this.plBack.Name = "plBack";
            this.plBack.Size = new System.Drawing.Size(170, 120);
            this.plBack.TabIndex = 0;
            // 
            // picClose
            // 
            this.picClose.Image = global::sin_MsgForm.Properties.Resources.exit3;
            this.picClose.Location = new System.Drawing.Point(142, 11);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(15, 16);
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 120);
            this.Controls.Add(this.plBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plBack;
        private System.Windows.Forms.PictureBox picClose;
    }
}