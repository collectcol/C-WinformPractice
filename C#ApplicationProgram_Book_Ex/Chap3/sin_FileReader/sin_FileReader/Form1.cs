using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sin_FileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtPath.Text = ofdFile.FileName;
            }
        }

        private void btnAllRead_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPath.Text))
            {
                MessageBox.Show("파일 경로를 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (File.Exists(txtPath.Text))
                {
                    using (StreamReader sr = new StreamReader(txtPath.Text))
                    {
                        this.txtView.Text = sr.ReadToEnd();
                    }
                }
                else
                {
                    MessageBox.Show("읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"파일을 읽는 중 오류가 발생했습니다: {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool txtCheck()
        {
            if (this.txtPath.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLineRead_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPath.Text))
            {
                MessageBox.Show("파일 경로를 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.txtView.Clear();

            try
            {
                if (File.Exists(txtPath.Text))
                {
                    using (StreamReader sr = new StreamReader(txtPath.Text))
                    {
                        string line = null;
                        while ((line = sr.ReadLine()) != null)
                        {
                            this.txtView.AppendText(line + "\r\n");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"파일을 읽는 중 오류가 발생했습니다: {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
