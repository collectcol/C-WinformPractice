namespace sin_ReceiveData
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
            this.lalReceive01 = new System.Windows.Forms.Label();
            this.lblReceive02 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lalReceive01
            // 
            this.lalReceive01.AutoSize = true;
            this.lalReceive01.Location = new System.Drawing.Point(57, 46);
            this.lalReceive01.Name = "lalReceive01";
            this.lalReceive01.Size = new System.Drawing.Size(129, 12);
            this.lalReceive01.TabIndex = 0;
            this.lalReceive01.Text = "외부에서 받은 데이터 :";
            // 
            // lblReceive02
            // 
            this.lblReceive02.AutoSize = true;
            this.lblReceive02.Location = new System.Drawing.Point(192, 46);
            this.lblReceive02.Name = "lblReceive02";
            this.lblReceive02.Size = new System.Drawing.Size(29, 12);
            this.lblReceive02.TabIndex = 1;
            this.lblReceive02.Text = "결과";
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(461, 38);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(67, 28);
            this.btnReceive.TabIndex = 2;
            this.btnReceive.Text = "전달받기";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 104);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.lblReceive02);
            this.Controls.Add(this.lalReceive01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "외부 데이터 받기(Without Thread)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalReceive01;
        private System.Windows.Forms.Label lblReceive02;
        private System.Windows.Forms.Button btnReceive;
    }
}