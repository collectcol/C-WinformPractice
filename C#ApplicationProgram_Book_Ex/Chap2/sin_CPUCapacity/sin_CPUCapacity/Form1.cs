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
using System.Diagnostics;

namespace sin_CPUCapacity
{
    public partial class Form1 : Form
    {
        
        private PerformanceCounter oCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");    // 시스템 성능 카운터
        private volatile bool bExit = false; // 실시간 체크를 위한 While 조건
        private int iCPU = 0;       // CPU 초기 사용률
        private Font F = new Font("굴림", 9);
        private Thread checkThread;
        private delegate void ProcessEventHandler(int Current);
        private ProcessEventHandler ResultView = null;

        public Form1()      
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResultView += new ProcessEventHandler(Current);

            checkThread = new Thread(getCPU_Info);
            checkThread.Start();
        }

        private void getCPU_Info()
        {
            while (!bExit)
            {
                iCPU = (int)oCPU.NextValue();
                Invoke(ResultView, iCPU);
                Thread.Sleep(1000);
            }
        }

        private void Current(int Current)
        {
            this.Text = "CPU 사용 : " + Current.ToString() + " %";
            iCPU = Current * 3;
            plBar.Invalidate();
        }

        private void plBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (iCPU <= 60) g.FillRectangle(Brushes.BlanchedAlmond, 0, 0, iCPU, plBar.Height);
            else if (iCPU <= 120) g.FillRectangle(Brushes.Wheat, 0, 0, iCPU, plBar.Height);
            else if (iCPU <= 180) g.FillRectangle(Brushes.NavajoWhite, 0, 0, iCPU, plBar.Height);
            else if (iCPU <= 240) g.FillRectangle(Brushes.Orange, 0, 0, iCPU, plBar.Height);
            else g.FillRectangle(Brushes.DarkOrange, 0, 0, iCPU, plBar.Height);

            iCPU = iCPU / 3;
            g.DrawString(iCPU.ToString() + " %", F, Brushes.DarkRed, plBar.Width / 2 - 17, plBar.Height / 4);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bExit = true;
            checkThread.Join();
            oCPU.Dispose();
            F.Dispose();
        }
    }
}
