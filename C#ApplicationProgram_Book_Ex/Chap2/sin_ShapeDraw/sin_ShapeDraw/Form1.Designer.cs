namespace sin_ShapeDraw
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
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.rbRect = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.plPaint = new System.Windows.Forms.Panel();
            this.gbOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOption
            // 
            this.gbOption.Controls.Add(this.rbRect);
            this.gbOption.Controls.Add(this.rbLine);
            this.gbOption.Location = new System.Drawing.Point(12, 12);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(540, 51);
            this.gbOption.TabIndex = 0;
            this.gbOption.TabStop = false;
            this.gbOption.Text = "Option";
            // 
            // rbRect
            // 
            this.rbRect.AutoSize = true;
            this.rbRect.Location = new System.Drawing.Point(188, 20);
            this.rbRect.Name = "rbRect";
            this.rbRect.Size = new System.Drawing.Size(95, 16);
            this.rbRect.TabIndex = 2;
            this.rbRect.Text = "사각형그리기";
            this.rbRect.UseVisualStyleBackColor = true;
            this.rbRect.CheckedChanged += new System.EventHandler(this.rbRect_CheckedChanged);
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Checked = true;
            this.rbLine.Location = new System.Drawing.Point(19, 20);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(83, 16);
            this.rbLine.TabIndex = 1;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "라인그리기";
            this.rbLine.UseVisualStyleBackColor = true;
            this.rbLine.CheckedChanged += new System.EventHandler(this.rbLine_CheckedChanged);
            // 
            // plPaint
            // 
            this.plPaint.BackColor = System.Drawing.Color.White;
            this.plPaint.Location = new System.Drawing.Point(12, 69);
            this.plPaint.Name = "plPaint";
            this.plPaint.Size = new System.Drawing.Size(540, 404);
            this.plPaint.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 485);
            this.Controls.Add(this.plPaint);
            this.Controls.Add(this.gbOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "라인 사각형 그리기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOption.ResumeLayout(false);
            this.gbOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.RadioButton rbRect;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.Panel plPaint;
    }
}