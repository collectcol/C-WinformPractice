using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NativeWifi; // ManagedWifi 참조 파일이다.bin 파일안에 들어있음
using System.Threading;
using System.ServiceProcess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;

namespace sin_WifiScanner
{
    public partial class Form1 : Form
    {
        WlanClient wlanClient;
        Thread thrAP = null;
        private delegate void OnWifiDelegate(ListViewItem lvi, bool f);
        private OnWifiDelegate OnWifi = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WifiChecking();
            ScanWifi();
            //wlanClient = new WlanClient();
            //OnWifi = new OnWifiDelegate(OnWifiView);
            //thrAP = new Thread(ThreadList);
            //thrAP.Start();
        }
        private void ScanWifi()
        {
            // Wi-Fi 네트워크 스캔 및 정보 가져오기
            List<string[]> wifiNetworks = new List<string[]>();

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in interfaces)
            {
                if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 && networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    string ssid = "";
                    string signalStrength = "";
                    string encryption = "";
                    string channel = "";
                    string encryptionMethod = "";
                    string authenticationMethod = "";
                    string macAddress = networkInterface.GetPhysicalAddress().ToString();

                    foreach (var unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
                    {
                        if (unicastAddress.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            ssid = unicastAddress.Address.ToString();
                        }
                    }

                    // 위의 정보들을 배열에 저장
                    string[] networkInfo = { ssid, signalStrength, encryption, channel, encryptionMethod, authenticationMethod, macAddress };

                    wifiNetworks.Add(networkInfo);
                }
            }

            // 리스트뷰에 Wi-Fi 네트워크 정보 표시
            foreach (string[] networkInfo in wifiNetworks)
            {
                ListViewItem item = new ListViewItem(networkInfo);
                lvAP.Items.Add(item);
            }
        }

        private void WifiChecking()
        {
            ServiceController wifiService = new ServiceController("WlanSvc");

            if (wifiService.Status != ServiceControllerStatus.Running)
            {
                // Wifi서비스가 실행중이 아닌경우 서비스 시작
                wifiService.Start();
                wifiService.WaitForStatus(ServiceControllerStatus.Running);
            }
        }

        // 검색된 Wifi를 lvAP 컨트롤에 나타내는 작업
        //private void OnWifiView(ListViewItem lvi, bool f)
        //{
        //    if (f == true)
        //    {
        //        this.lvAP.Items.Add(lvi);
        //    }
        //    else
        //    {
        //        this.lvAP.Items.Clear();
        //    }
        //}

        // Wifi를 검색하여 해당하는 정보를 lvAP 컨트롤에 출력하기
        //private void ThreadList()
        //{
        //    try
        //    {
        //        while (true)
        //        {
        //            Invoke(OnWifi, null, false);
        //            // 로컬 컴퓨터의 무선 랜카드에서 얻은 Wifi 정보를 배열에 저장
        //            if (wlanClient.Interfaces.Length > 0)
        //            {
        //                Wlan.WlanAvailableNetwork[] wlanBssEntries = wlanClient.Interfaces[0].GetAvailableNetworkList(0);
        //                foreach (Wlan.WlanAvailableNetwork network in wlanBssEntries)
        //                {
        //                    var lvt = new ListViewItem(new string[]
        //                    {
        //                        GetStringForSSID(network.dot11Ssid), // Wifi 이름을 lvt 개체에 저장하는 작업을 수행, network.dot11Ssid가 아스키 형태로 되어 있기때문에
        //                                                             // 문자 형태로 변환하기 위해서 GetStringForSSID() 메서드 사용

        //                        network.wlanSignalQuality.ToString(),// Wifi의 신호 강도 
        //                        network.securityEnabled.ToString(),  // Wifi의 암호화 여부 정보
        //                        GetMacChanel(1, ConvertToMAC(network.dot11Ssid.SSID)), // 채널정보
        //                        network.dot11DefaultCipherAlgorithm.ToString(), // 암호화 장식 정보
        //                        network.dot11DefaultAuthAlgorithm.ToString(),   // 인증 방식 정보
        //                        GetMacChanel(2, ConvertToMAC(network.dot11Ssid.SSID)) // MAC 주소
        //                    });
        //                    Invoke(OnWifi, lvt, true);
        //                }
        //            }
        //            Thread.Sleep(10000);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("오류발생 : " + ex.Message);
        //    }

        //}

        //private string GetMacChanel(int i , string Name)
        //{
        //    // 로컬 컴퓨터의 무선 랜카드에서 얻은 Wifi Raw 정보를 Wlan.WlanBssEntry 배열에 반환.
        //    Wlan.WlanBssEntry[] lstWlanBss = wlanClient.Interfaces[0].GetNetworkBssList();
        //    var reAP = "";
        //    foreach (var oWlan in lstWlanBss)
        //    {
        //        if (i == 2)
        //        {
        //            if (ConvertToMAC(oWlan.dot11Ssid.SSID) == Name)
        //            {
        //                reAP = ConvertToMAC(oWlan.dot11Bssid);
        //            }
        //        }
        //        else if (i == 1)
        //        {
        //            if (ConvertToMAC(oWlan.dot11Ssid.SSID) == Name)
        //            {
        //                var chnl = oWlan.chCenterFrequency.ToString();
        //                switch (chnl)
        //                {
        //                    case "2412000":
        //                        reAP = "1";
        //                        break;
        //                    case "2417000":
        //                        reAP = "2";
        //                        break;
        //                    case "2422000":
        //                        reAP = "3";
        //                        break;
        //                    case "2427000":
        //                        reAP = "4";
        //                        break;
        //                    case "2432000":
        //                        reAP = "5";
        //                        break;
        //                    case "2437000":
        //                        reAP = "6";
        //                        break;
        //                    case "2442000":
        //                        reAP = "7";
        //                        break;
        //                    case "2447000":
        //                        reAP = "8";
        //                        break;
        //                    case "2452000":
        //                        reAP = "9";
        //                        break;
        //                    case "2457000":
        //                        reAP = "10";
        //                        break;
        //                    case "2462000":
        //                        reAP = "11";
        //                        break;
        //                    case "2467000":
        //                        reAP = "12";
        //                        break;
        //                    case "2472000":
        //                        reAP = "13";
        //                        break;
        //                }
        //            }
        //        }
        //    }
        //    return reAP;
        //}

        //string ConvertToMAC(byte[] MAC)
        //{
        //    string strMAC = "";
        //    for (int index = 0; index < 6; index++)
        //    {
        //        strMAC += MAC[index].ToString("X2") + "-";
        //    }
        //    return strMAC;
        //}

        //static string GetStringForSSID(Wlan.Dot11Ssid ssid)
        //{
        //    return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
        //}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (this.thrAP != null)
            //{
            //    thrAP.Abort();
            //    Application.ExitThread();
            //}
        }
    }
}
