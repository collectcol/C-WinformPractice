using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; // IPAddress 클래스 사용
using System.Net.Sockets; // TcpListener 클래스 사용
using System.Threading;
using System.IO;
using Microsoft.Win32; // 레지스트리 클래스 사용
using System.Runtime.InteropServices; // 폼 깜빡임 구현
using System.Diagnostics.Eventing.Reader;

namespace sin_Message
{
    public partial class Form1 : Form
    {
        private TcpListener server;     // TCP 네트워크 클라이언트에서 연결 수신
        private TcpClient serClient;    // TCP 네트워크 서비스에 대한 클라이언트 연결 제공
        private NetworkStream myStream; // 네트워크 스트림
        private StreamReader myRead;    // 스트림 읽기
        private StreamWriter myWrite;   // 스트림 쓰기
        private Boolean start = false;  // 서버 시작
        private Boolean clientCon = false;  // 클라이언트 시작
        private int myPort;             // 포트
        private string myName;          // 별칭
        private Thread myReader, myServer;  // 스레드
        private Boolean textChange = false; // 입력 컨트롤의 데이터입력 체크
        private bool textSend = false;  // 서버 데이터 입력 유효성 체크

        // 레지스트리 쓰기, 읽기
        private RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\.NETFramework", true);

        private delegate void AddTextDelegate(string strText);  // 델리게이트 개체 생성
        private AddTextDelegate AddText = null; // 델리게이트 개체 생성

        [DllImport("User32.dll")]
        private static extern bool FlashWindow(IntPtr hwnd, bool blnvert);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // GetValue()로 레즈스트리 키값이 설정되었는지 유무 판단
            if ((string)key.GetValue("Message_name") == "")
            {
                this.myName = this.txtId.Text;
                this.myPort = Convert.ToInt32(this.txtPort.Text);
            }
            else
            {
                try
                {
                    this.myName = (string)key.GetValue("Message_name");
                    this.myPort = Convert.ToInt32(key.GetValue("Message_port"));
                }
                catch
                {
                    this.myName = this.txtId.Text;
                    this.myPort = Convert.ToInt32(this.txtPort.Text);
                }
            }
        }

        private void tsmiOption_Click(object sender, EventArgs e)
        {
            this.tsmiOption.Enabled = false;
            this.plOption.Visible = true;
            this.txtId.Focus();
            this.txtId.Text = (string)key.GetValue("Message_name");     // 별칭 입력
            this.txtPort.Text = (string)key.GetValue ("Message_port");  // 포트 입력
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.cbServer.Checked == true)
            {
                ControlCheck();
            }
            else
            {
                if (this.txtIp.Text == "")
                {
                    this.txtIp.Focus();
                }
                else
                {
                    ControlCheck();
                }
            }
        }

        private void ControlCheck()
        {
            if (this.txtId.Text == "")
            {
                this.txtId.Focus();
            }
            else if (this.txtPort.Text == "")
            {
                this.txtPort.Focus();
            }
            else
            {
                try
                {
                    var name = this.txtId.Text;
                    var port = this.txtPort.Text;
                    key.SetValue("Message_name", name);
                    key.SetValue("Message_port", port);
                    this.plOption.Visible = false;
                    this.tsmiOption.Enabled = true;
                    this.tsbtnConn.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("설정이 저장되지 않았습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void cbServer_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbServer.Checked) // 서버 또는 클라이언트 체크 해제
            {
                this.txtIp.Enabled = false; // 서버 모드 전환
            }
            else
            {
                this.txtIp.Enabled = true; // 클라이언트 모드 전환
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ServerStop();
            }
            catch
            {
                Disconnection();
            }
        }

        private void tsbtnConn_Click(object sender, EventArgs e)
        {
            AddText = new AddTextDelegate(MessageView);
            if (this.cbServer.Checked)
            {
                var addr = new IPAddress(0);
                try
                {
                    this.myName = (string)key.GetValue("Message_name");
                    this.myPort = Convert.ToInt32(key.GetValue("Message_port"));
                }
                catch
                {
                    this.myName = this.txtId.Text;
                    this.myPort = Convert.ToInt32(this.txtPort.Text);
                }

                if (!(this.start))
                {
                    try
                    {
                        server = new TcpListener(addr, this.myPort);
                        server.Start();

                        this.start = true;
                        this.txtMessage.Enabled = true;
                        this.btnSend.Enabled = true;
                        this.txtMessage.Focus();
                        this.tsbtnDisconn.Enabled = true;
                        this.tsbtnConn.Enabled = false;
                        this.cbServer.Enabled = true;

                        myServer = new Thread(ServerStart);
                        myServer.Start();

                        this.tsmiOption.Enabled = false;
                    }
                    catch
                    {
                        Invoke(AddText, "서버를 실행할 수 없습니다.");
                    }
                }
                else
                {
                    ServerStop();
                }
            }
            else
            {
                if (!(this.clientCon))
                {
                    this.myName = (string)key.GetValue("Message_name"); // 별칭 설정
                    // 서버측 포트 설정
                    this.myPort = Convert.ToInt32(key.GetValue("Message_port"));
                    ClientConnection();
                }
                else
                {
                    this.txtMessage.Enabled = false;
                    this.btnSend.Enabled = false;
                    Disconnection();
                }
            }
        }

        private void MessageView(string strText)
        {
            this.rtbText.AppendText(strText + "\r\n");
            this.rtbText.Focus();
            this.rtbText.ScrollToCaret();
            this.txtMessage.Focus();
        }

        private void ServerStart()
        {
            Invoke(AddText, "서버 실행 : 챗 상대의 접속을 기다립니다...");
            while (start)
            {
                try 
                { 
                    serClient = server.AcceptTcpClient();
                    Invoke(AddText, " 챗 상대 접속..");
                    myStream = serClient.GetStream();

                    myRead = new StreamReader(myStream);
                    myWrite = new StreamWriter(myStream);
                    this.clientCon = true;
                    textSend = true;

                    myReader = new Thread(Receive);
                    myReader.Start();
                }
                catch { }
            }
        }

        private void ClientConnection()
        {
            try
            {
                client = new TcpClient(this.txtIp.Text, this.myPort);
            }
        }
    }
}
