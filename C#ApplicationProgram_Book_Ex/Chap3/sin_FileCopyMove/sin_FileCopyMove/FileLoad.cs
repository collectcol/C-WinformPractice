﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace sin_FileCopyMove
{
    public partial class FileLoad : Form
    {
        public delegate void SetProgCallBack(int vy);    // 진행률 Progress
        public delegate void SetLabelCallBack(string str);  // 진행률 텍스트

        private Thread tl;                      // 스레드 개체 생성
        private byte[] bts = new byte[4096];    // 파일 분할 저장
        private FileStream fsSrc = null;        // 소스 파일 스트림 개체 생성
        private FileStream fsDest = null;       // 복적지 파일 스트림 개체 생성

        public FileLoad(string src, string dest)
        {
            InitializeComponent();
            fsSrc = new FileStream(src, FileMode.Open, FileAccess.Read);
            fsDest = new FileStream(dest, FileMode.Create, FileAccess.Write);
        }

        private void FileLoad_Load(object sender, EventArgs e)
        {
            this.pgbCopy.Maximum = 100;
            tl = new Thread(new ThreadStart(FileCopy));
            tl.Start();
        }

        private void FileCopy()
        {
            int vv = 1;
            int cnt = 0;
            int kk = (int)(fsSrc.Length / 4096) -1;
            int ss = (int)(fsSrc.Length % 4096);

            while (true)
            {
                Thread.Sleep(10);
                if (vv >= 100)
                {
                    break;
                }

                bts = new byte[4096];

                if (cnt <= kk)
                {
                    fsSrc.Seek(4096 & cnt, SeekOrigin.Begin);
                    fsSrc.Read(bts, 0, 4096);

                    fsDest.Seek(4096 * cnt, SeekOrigin.Begin);
                    fsDest.Write(bts, 0, 4096);
                }
                else
                {
                    fsSrc.Seek(4096 * cnt, SeekOrigin.Begin);
                    fsSrc.Read(bts, 0, ss);

                    fsDest.Seek(4096 * cnt, SeekOrigin.Begin);
                    fsDest.Write(bts, 0, ss);
                }

                cnt++;

                vv = (int)(fsDest.Length * 100 / fsSrc.Length);
                if (vv > 100)
                {
                    SetProgBar(100);
                }
                else
                {
                    SetProgBar(vv);
                }
                SetLabel("복사 : " + vv.ToString() + "%");
            }
            fsDest.Close();
            fsSrc.Close();
            DialogResult = DialogResult.OK;
        }

        private void SetProgBar(int vv)
        {
            if (this.pgbCopy.InvokeRequired)
            {
                SetProgCallBack del = new SetProgCallBack(SetProgBar);
                this.Invoke(del, new object[] {vv});
            }
        }

        private void SetLabel(string str)
        {
            if (this.lblCopy.InvokeRequired)
            {
                SetLabelCallBack del = new SetLabelCallBack(SetLabel);
                this.Invoke(del, new object[] { str });
            }
            else
            {
                this.lblCopy.Text = str;
            }
        }

        private void FileLoad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tl != null)
            {
                tl.Abort();
            }
        }
    }
}
