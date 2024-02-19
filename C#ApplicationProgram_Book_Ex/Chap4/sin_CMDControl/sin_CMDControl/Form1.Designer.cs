namespace sin_CMDControl
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
            this.btnCMD = new System.Windows.Forms.Button();
            this.btnCommand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.lbList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCMD
            // 
            this.btnCMD.Location = new System.Drawing.Point(12, 30);
            this.btnCMD.Name = "btnCMD";
            this.btnCMD.Size = new System.Drawing.Size(140, 34);
            this.btnCMD.TabIndex = 0;
            this.btnCMD.Text = "CMD RUN";
            this.btnCMD.UseVisualStyleBackColor = true;
            this.btnCMD.Click += new System.EventHandler(this.btnCMD_Click);
            // 
            // btnCommand
            // 
            this.btnCommand.Location = new System.Drawing.Point(648, 30);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(140, 34);
            this.btnCommand.TabIndex = 1;
            this.btnCommand.Text = "Command";
            this.btnCommand.UseVisualStyleBackColor = true;
            this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "명령어 :";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(241, 38);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(401, 21);
            this.txtCommand.TabIndex = 3;
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 12;
            this.lbList.Location = new System.Drawing.Point(12, 89);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(776, 340);
            this.lbList.TabIndex = 4;
            this.lbList.SelectedIndexChanged += new System.EventHandler(this.lbList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCommand);
            this.Controls.Add(this.btnCMD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "CMD Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCMD;
        private System.Windows.Forms.Button btnCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.ListBox lbList;
    }
}