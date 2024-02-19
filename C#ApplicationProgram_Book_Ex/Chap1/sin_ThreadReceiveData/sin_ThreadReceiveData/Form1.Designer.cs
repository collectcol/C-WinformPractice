namespace sin_ThreadReceiveData
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
            this.lblReceive01 = new System.Windows.Forms.Label();
            this.lblReceive02 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReceive01
            // 
            this.lblReceive01.AutoSize = true;
            this.lblReceive01.Location = new System.Drawing.Point(37, 27);
            this.lblReceive01.Name = "lblReceive01";
            this.lblReceive01.Size = new System.Drawing.Size(133, 12);
            this.lblReceive01.TabIndex = 0;
            this.lblReceive01.Text = "외부에서 받은 데이터 : ";
            // 
            // lblReceive02
            // 
            this.lblReceive02.AutoSize = true;
            this.lblReceive02.Location = new System.Drawing.Point(176, 27);
            this.lblReceive02.Name = "lblReceive02";
            this.lblReceive02.Size = new System.Drawing.Size(29, 12);
            this.lblReceive02.TabIndex = 1;
            this.lblReceive02.Text = "결과";
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(329, 27);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(106, 24);
            this.btnReceive.TabIndex = 2;
            this.btnReceive.Text = "전달받기";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 77);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.lblReceive02);
            this.Controls.Add(this.lblReceive01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "외부 데이터 받기(With Thread)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceive01;
        private System.Windows.Forms.Label lblReceive02;
        private System.Windows.Forms.Button btnReceive;
    }
}