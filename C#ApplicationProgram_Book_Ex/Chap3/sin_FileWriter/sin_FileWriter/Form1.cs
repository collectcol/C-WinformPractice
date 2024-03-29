﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sin_FileWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (sfdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtPath.Text = sfdFile.FileName;
            }
        }

        private void btnLineSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.txtPath.Text))
                {
                    sw.WriteLine(this.txtSave.Text);
                }
            }
            catch
            {
                return;
            }
            MessageBox.Show("파일이 정상적으로 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLineRead_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.txtPath.Text))
                {
                    foreach (var str in txtSave.Lines)
                    {
                        sw.WriteLine(str);
                    }
                }
            }
            catch
            {
                return;
            }
            MessageBox.Show("파일이 정상적으로 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
