using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sin_NetworkMap
{
    public partial class Form2 : Form
    {
        public string ItemId { set { this.txtId.Text = value; } }
        public string ItemName { set { this.txtName.Text = value; } }
        public int ItemDesc { 
            set 
            { 
                this.txtDesc.Text = ItemManage.ItemDesc[value];
                Num = value;
            } 
        }

        private int Num = 0;
        public Point Itemxy { set { LocationXY = value; } }

        Point LocationXY = new Point();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = LocationXY;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ItemManage.ItemId = this.txtId.Text;
            ItemManage.ItemName = this.txtName.Text;
            ItemManage.ItemDesc[Num] = this.txtDesc.Text;

            var dlr = MessageBox.Show("Item 정보를 저장합니다."
                , "저장", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            switch (dlr)
            {
                case DialogResult.Yes:
                    this.Dispose();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
