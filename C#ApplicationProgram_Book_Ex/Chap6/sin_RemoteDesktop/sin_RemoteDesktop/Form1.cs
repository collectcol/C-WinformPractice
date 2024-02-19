using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sin_RemoteDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbPixel.Text = "1024 x 768";
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            if (this.txtIp.Text == "")
            {
                MessageBox.Show("아이피를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtIp.Focus();
            }
            else if (this.txtId.Text == "")
            {
                MessageBox.Show("아이디를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtId.Focus();
            }
            else if (this.txtPwd.Text == "")
            {
                MessageBox.Show("비밀번호를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPwd.Focus();
            }
            else
            {
                Form2 frm2 = new Form2();
                frm2._IP = this.txtIp.Text;
                frm2._Port = this.txtPort.Text;
                frm2._ID = this.txtId.Text;
                frm2._Pwd = this.txtPwd.Text;
                frm2._Pixel = new Point(
                    Convert.ToInt32(this.cbPixel.Text.Split('x')[0].Trim()),
                    Convert.ToInt32(this.cbPixel.Text.Split('x')[0].Trim()));
                this.Visible = false;
                var dlg = frm2.ShowDialog();
                if (dlg == DialogResult.No)
                {
                    this.Visible = true;
                    MessageBox.Show("원격 연결이 실패하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dlg == DialogResult.OK)
                {
                    this.Visible = true;
                    this.TopMost = true;
                }
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
