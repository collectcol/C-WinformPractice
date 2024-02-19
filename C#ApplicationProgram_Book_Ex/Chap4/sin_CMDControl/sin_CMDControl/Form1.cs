using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace sin_CMDControl
{
    // 오류 코드들이다. 만약 이 코드를 본다면 구글링해서 ProcessInfo와 Process 를 써서 하던지
    // 아니면 이 코드를 뜯어 고치던지 해보자.
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern int FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int IParam);

        [DllImport("user32.dll")]
        public static extern int PostMessage(int hWnd, int wMsg, int wParam, int IParam);

        private const int WM_CHAR = 0x0102;
        private const int WM_KEYDOWN = 0x100;
        private const int VK_RETURN = 0x0D;

        Process cmdProcess = new Process(); // CMD 실행을 위한 개체 생성

        int iHandle; // CMD 핸들값
                     // 핸들값이란 프로그램이 운영 체제 상의 리소스를 식별하고 참조하기 위한 고유한 식별자
                     // 이러한 리소스에는 파일, 메모리, 프로세스, 스레드, 창 및 다양한 시스템 개체 등이 포함될 수 있다.

        int CurrentiHandle;

        Thread CmdThre = null;
        private delegate void OnDelegateCmd(string SiHandle);
        private OnDelegateCmd OnCmd = null;

        Thread CmmThre = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnCmd = new OnDelegateCmd(OnDelCmd);
        }

        private void OnDelCmd(string SiHandle)
        {
            lbList.Items.Add(SiHandle);
        }

        private void btnCMD_Click(object sender, EventArgs e)
        {
            CmdThre = new Thread(CmdThreRun);
            CmdThre.Start();
        }

        private void CmdThreRun()
        {
            cmdProcess.StartInfo.FileName = "cmd.exe";
            cmdProcess.Start();
            Thread.Sleep(500);
            iHandle = FindWindow(null, @"C:\Windows\system32\cmd.exe");
            Invoke(OnCmd, iHandle.ToString());
            CmdThre.Abort();
        }

        private void lbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentiHandle = Convert.ToInt32(this.lbList.SelectedItem.ToString());
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            CmmThre = new Thread(new ParameterizedThreadStart(CommandThre));
            CmmThre.Start(this.txtCommand.Text);
            this.lbList.Items.Clear();
        }

        private void CommandThre(object o)
        {
            string cmdstr = (string)o;
            foreach (char stra in cmdstr)
            {
                SendMessage(CurrentiHandle, WM_CHAR, (int)stra, 0);
            }
            PostMessage(CurrentiHandle, WM_KEYDOWN, VK_RETURN, 0);

            Thread.Sleep(10);
            Process[] tProcess = Process.GetProcessesByName("cmd");
            for (int i = 0; i < tProcess.Length; i++)
            {
                Invoke(OnCmd, tProcess[i].MainWindowHandle.ToString());
            }
        }
    }
}
