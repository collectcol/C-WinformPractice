namespace sin_LineRect
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
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(56, 286);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(124, 25);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "라인 그리기";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(253, 287);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(101, 22);
            this.btnRect.TabIndex = 1;
            this.btnRect.Text = "도형 그리기";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 367);
            this.Controls.Add(this.btnRect);
            this.Controls.Add(this.btnLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "라인 및 도형 그리기";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRect;
    }
}