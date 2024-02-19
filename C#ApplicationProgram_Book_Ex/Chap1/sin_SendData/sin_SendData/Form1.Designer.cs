namespace sin_SendData
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
            this.lalSend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lalSend
            // 
            this.lalSend.AutoSize = true;
            this.lalSend.Location = new System.Drawing.Point(143, 34);
            this.lalSend.Name = "lalSend";
            this.lalSend.Size = new System.Drawing.Size(250, 12);
            this.lalSend.TabIndex = 0;
            this.lalSend.Text = "Receiver로 문자열 \"신우경\" 값이 전달됩니다.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 84);
            this.Controls.Add(this.lalSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "데이터 전달";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalSend;
    }
}