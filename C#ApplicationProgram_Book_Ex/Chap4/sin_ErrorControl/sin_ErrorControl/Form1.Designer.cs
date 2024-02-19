namespace sin_ErrorControl
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnReRun = new System.Windows.Forms.Button();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(127, 60);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(91, 35);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "상태 감시";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnReRun
            // 
            this.btnReRun.Location = new System.Drawing.Point(42, 145);
            this.btnReRun.Name = "btnReRun";
            this.btnReRun.Size = new System.Drawing.Size(91, 35);
            this.btnReRun.TabIndex = 1;
            this.btnReRun.Text = "재실행";
            this.btnReRun.UseVisualStyleBackColor = true;
            this.btnReRun.Click += new System.EventHandler(this.btnReRun_Click);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(211, 145);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(91, 35);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "버튼 클릭";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 261);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.btnReRun);
            this.Controls.Add(this.btnCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Error Control";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnReRun;
        private System.Windows.Forms.Button btnClick;
    }
}