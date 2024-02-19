namespace sin_ParameterThread
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
            this.lblSum = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnSUM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(12, 9);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(32, 12);
            this.lblSum.TabIndex = 0;
            this.lblSum.Text = "SUM";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 33);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(41, 12);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "결과 : ";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(65, 6);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(94, 21);
            this.txtNum.TabIndex = 2;
            // 
            // btnSUM
            // 
            this.btnSUM.Location = new System.Drawing.Point(179, 9);
            this.btnSUM.Name = "btnSUM";
            this.btnSUM.Size = new System.Drawing.Size(85, 19);
            this.btnSUM.TabIndex = 3;
            this.btnSUM.Text = "SUM";
            this.btnSUM.UseVisualStyleBackColor = true;
            this.btnSUM.Click += new System.EventHandler(this.btnSUM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 69);
            this.Controls.Add(this.btnSUM);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Witout Delegate Parameter Thread";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnSUM;
    }
}