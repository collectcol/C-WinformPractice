using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace sin_ErrorControl
{
    public partial class Form1 : Form
    {
        // 윈도우 폼의 핸들 값을 가져온다.
        [DllImport("user32.dll")]
        public static extern int FindWindow(string IpClassName, string IpWindowName);
        // 윈도우 폼의 핸들값으로 다시 윈도우 폼에 갖고 있는 버튼 등의 컨트롤의 핸들 값을 가져온다.
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int FindWindowEx(int parentHandle, IntPtr childAfter, string lpsz1, string lpsz2);
        // 컨트롤의 핸들값을 이용하여 버튼을 누름
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int IParam);
        private const int BM_CLICK = 0x00F5;

        Thread ThreadCheckThre = null;
        Thread CheckThre = null;
        Thread BtnThre = null;
        Process ps = new Process();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckThre = new Thread(ErrorCheck);
            CheckThre.Start();
        }

        private void ErrorCheck()
        {
            int nhwndl = 0;
            try
            {
                nhwndl = FindWindow(null, "ErrorForm");
            }
            catch { }
            if (nhwndl > 0)
            {
                while (true)
                {
                    int childHandle = FindWindowEx(nhwndl, IntPtr.Zero, "WindowsForms10.BUTTON.app.0.141b42a_r8_ad1", "끝내기");
                    if(childHandle > 0)
                    {
                        SendMessage((IntPtr)childHandle, BM_CLICK, 0, 1);
                        break;
                    }
                }
            }
            CheckThre.Abort();
        }

        private void btnReRun_Click(object sender, EventArgs e)
        {
            ps.StartInfo.FileName = "C:\\Users\\ManLab01\\Desktop\\Reference Materials\\C#프로그래밍\\Chap4\\sin_Error\\sin_Error\\bin\\Release\\sin_Error.exe";
            ps.Start();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            BtnThre = new Thread(BtnClick);
            BtnThre.Start();
        }

        private void BtnClick()
        {
            int nhwndl = 0;
            try
            {
                nhwndl = FindWindow(null, "Error");
            }
            catch { }
            if (nhwndl > 0)
            {
                while (true)
                {
                    int childHandlel = FindWindowEx(nhwndl, IntPtr.Zero, "WindowsForms10.BUTTON.app.0.141b42a_r8_ad1", "Error"); // Error는 버튼의 이름
                    if (childHandlel > 0)
                    {
                        SendMessage((IntPtr)childHandlel, BM_CLICK, 0, 1);
                        break;
                    }
                }
            }
            BtnThre.Abort();
        }
    }
}
