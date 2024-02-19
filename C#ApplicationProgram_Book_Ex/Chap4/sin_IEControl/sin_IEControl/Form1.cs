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
using SHDocVw;
using Microsoft.Win32;

namespace sin_IEControl
{
    public partial class Form1 : Form
    {
        [DllImport("wininet.dll")]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr IpBuffer, int dwBufferLength);
        private const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        private const int INTERNET_OPTION_REFRESH = 37;
        private bool settingsReturn, refreshReturn;

        // 프록시 설정을 위한 레지스트리 개체 생성
        RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
        // 인터넷 익스플로러를 제어하기 위한 개체 생성
        InternetExplorer ie = new InternetExplorer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (registry.GetValue("ProxyEnable").ToString() == "0")
            {
                btnProxy.Text = "Proxy ON";
                this.txtProxy.Text = "";
                this.txtPort.Text = "";
            }
            else
            {
                btnProxy.Text = "Proxy OFF";
                string proxystr = registry.GetValue("ProxyServer").ToString();
                this.txtProxy.Text = proxystr.Split('.')[0];
                this.txtPort.Text = proxystr.Split('.')[1];
            }
        }

        private void btnProxy_Click(object sender, EventArgs e)
        {
            if (btnProxy.Text == "Proxy OFF")
            {
                btnProxy.Text = "Proxy ON";
                registry.SetValue("ProxyServer", "");
                registry.SetValue("ProxyEnable", 0);
                settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
            }
            else
            {
                btnProxy.Text = "Proxy OFF";
                registry.SetValue("ProxyServer", txtProxy.Text + ":" + txtPort.Text);
                registry.SetValue("ProxyEnable", 1);
                settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                this.txtProxy.Text = "";
                this.txtPort.Text = "";
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                ie.DocumentComplete += new DWebBrowserEvents2_DocumentCompleteEventHandler(ie_DocumentComplete);
                ie.Visible = true;
                ie.Navigate(this.txtUrl.Text);
            }
            catch
            {
                ie = new InternetExplorer();
                ie.DocumentComplete += new DWebBrowserEvents2_DocumentCompleteEventHandler(ie_DocumentComplete);
                ie.Visible = true;
                ie.Navigate(this.txtUrl.Text);
            }
        }

        private void ie_DocumentComplete(object pDisp, ref object e)
        {
            if (ie.ReadyState == SHDocVw.tagREADYSTATE.READYSTATE_COMPLETE)
            {
                this.tsslbStatus.Text = "진행 : 완료(" + this.txtUrl.Text + ")";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ie.DocumentComplete -= new DWebBrowserEvents2_DocumentCompleteEventHandler(ie_DocumentComplete);
            ie.Quit(); // 인터넷 익스플로러를 종료하는 작업과 ie 개체 리소스를 해제하는 작업 수행
        }
    }
}
