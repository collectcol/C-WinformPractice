namespace sin_GraphPaint
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
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnBar = new System.Windows.Forms.Button();
            this.GraphCore = new sin_GraphCore.sin_GraphCore();
            this.SuspendLayout();
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(560, 394);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(106, 24);
            this.btnGraph.TabIndex = 1;
            this.btnGraph.Text = "Graph";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnBar
            // 
            this.btnBar.Location = new System.Drawing.Point(672, 394);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(106, 24);
            this.btnBar.TabIndex = 2;
            this.btnBar.Text = "Bar";
            this.btnBar.UseVisualStyleBackColor = true;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // GraphCore
            // 
            this.GraphCore.Location = new System.Drawing.Point(12, 12);
            this.GraphCore.Name = "GraphCore";
            this.GraphCore.Size = new System.Drawing.Size(776, 376);
            this.GraphCore.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.GraphCore);
            this.Controls.Add(this.btnBar);
            this.Controls.Add(this.btnGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "그래프 그리기";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnBar;
        private sin_GraphCore.sin_GraphCore GraphCore;
    }
}