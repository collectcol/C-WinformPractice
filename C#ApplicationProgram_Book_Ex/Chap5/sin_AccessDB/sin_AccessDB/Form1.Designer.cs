namespace sin_AccessDB
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
            this.lvView = new System.Windows.Forms.ListView();
            this.plGroup = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblBlood = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.cbBlood = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBlood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvView
            // 
            this.lvView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNum,
            this.chId,
            this.chName,
            this.chAge,
            this.chSex,
            this.chBlood,
            this.chBirth,
            this.chPhone});
            this.lvView.FullRowSelect = true;
            this.lvView.GridLines = true;
            this.lvView.HideSelection = false;
            this.lvView.Location = new System.Drawing.Point(12, 12);
            this.lvView.Name = "lvView";
            this.lvView.Size = new System.Drawing.Size(745, 448);
            this.lvView.TabIndex = 0;
            this.lvView.UseCompatibleStateImageBehavior = false;
            this.lvView.View = System.Windows.Forms.View.Details;
            this.lvView.Click += new System.EventHandler(this.lvView_Click);
            // 
            // plGroup
            // 
            this.plGroup.BackColor = System.Drawing.Color.White;
            this.plGroup.Controls.Add(this.cbBlood);
            this.plGroup.Controls.Add(this.cbSex);
            this.plGroup.Controls.Add(this.txtPhone);
            this.plGroup.Controls.Add(this.txtBirth);
            this.plGroup.Controls.Add(this.txtAge);
            this.plGroup.Controls.Add(this.txtName);
            this.plGroup.Controls.Add(this.txtId);
            this.plGroup.Controls.Add(this.lblPhone);
            this.plGroup.Controls.Add(this.lblBirth);
            this.plGroup.Controls.Add(this.lblBlood);
            this.plGroup.Controls.Add(this.lblSex);
            this.plGroup.Controls.Add(this.lblAge);
            this.plGroup.Controls.Add(this.lblName);
            this.plGroup.Controls.Add(this.lblId);
            this.plGroup.Location = new System.Drawing.Point(12, 479);
            this.plGroup.Name = "plGroup";
            this.plGroup.Size = new System.Drawing.Size(578, 166);
            this.plGroup.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(34, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 12);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(34, 89);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(27, 12);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(34, 126);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(27, 12);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "Sex";
            // 
            // lblBlood
            // 
            this.lblBlood.AutoSize = true;
            this.lblBlood.Location = new System.Drawing.Point(289, 20);
            this.lblBlood.Name = "lblBlood";
            this.lblBlood.Size = new System.Drawing.Size(37, 12);
            this.lblBlood.TabIndex = 4;
            this.lblBlood.Text = "Blood";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(289, 55);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(30, 12);
            this.lblBirth.TabIndex = 5;
            this.lblBirth.Text = "Birth";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(289, 89);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 12);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(87, 17);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(183, 21);
            this.txtId.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 21);
            this.txtName.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(87, 86);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(183, 21);
            this.txtAge.TabIndex = 9;
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(342, 52);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(183, 21);
            this.txtBirth.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(342, 86);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(183, 21);
            this.txtPhone.TabIndex = 12;
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(87, 123);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(183, 20);
            this.cbSex.TabIndex = 13;
            // 
            // cbBlood
            // 
            this.cbBlood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBlood.FormattingEnabled = true;
            this.cbBlood.Location = new System.Drawing.Point(342, 17);
            this.cbBlood.Name = "cbBlood";
            this.cbBlood.Size = new System.Drawing.Size(183, 20);
            this.cbBlood.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(629, 479);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(629, 524);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(128, 32);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(629, 568);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chNum
            // 
            this.chNum.Text = "Num";
            // 
            // chId
            // 
            this.chId.Text = "ID";
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 100;
            // 
            // chAge
            // 
            this.chAge.Text = "Age";
            // 
            // chSex
            // 
            this.chSex.Text = "Sex";
            // 
            // chBlood
            // 
            this.chBlood.Text = "Blood";
            // 
            // chBirth
            // 
            this.chBirth.Text = "Birth";
            this.chBirth.Width = 100;
            // 
            // chPhone
            // 
            this.chPhone.Text = "Phone";
            this.chPhone.Width = 180;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 657);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.plGroup);
            this.Controls.Add(this.lvView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "인명부";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plGroup.ResumeLayout(false);
            this.plGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvView;
        private System.Windows.Forms.ColumnHeader chNum;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chAge;
        private System.Windows.Forms.ColumnHeader chSex;
        private System.Windows.Forms.ColumnHeader chBlood;
        private System.Windows.Forms.ColumnHeader chBirth;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.Panel plGroup;
        private System.Windows.Forms.ComboBox cbBlood;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblBlood;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
    }
}