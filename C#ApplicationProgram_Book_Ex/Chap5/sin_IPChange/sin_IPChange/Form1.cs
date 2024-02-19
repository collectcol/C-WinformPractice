using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;
using System.Configuration;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Reflection;

namespace sin_IPChange
{
    public partial class Form1 : Form
    {
        Configuration config;
        IPChange ip;
        
        bool loadCheck = true;

        // 현재 콤보박스에 선택된 명칭의 키값에서 index 솎아내서 담는 그릇
        string _index;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ip = new IPChange();
            
            GetNetworkInformation(FirstCheck());
            ChooseIPKeySetting();
        }

        private bool FirstCheck()
        {
            string initNICName = config.AppSettings.Settings["NICName0"]?.Value;
            return string.IsNullOrWhiteSpace(initNICName) ? true : false;
        }

        private void ChooseIPKeySetting()
        {
            cmbChooseIPKey.Items.Clear();

            Dictionary<string, string> dic = new Dictionary<string, string>();
            int index = 0;
            while (true)
            {
                string key = "NICName" + index.ToString();
                var value = config.AppSettings.Settings[key]?.Value;

                if (value != null)
                {
                    dic.Add(key, value);
                    index++;
                }
                else
                {
                    break;
                }
            }
            
            cmbChooseIPKey.DataSource = new BindingSource(dic, null);
            cmbChooseIPKey.SelectedIndexChanged += cmbChooseIPKey_SelectedIndexChanged;
            cmbChooseIPKey.DisplayMember = "Value";
            cmbChooseIPKey.ValueMember = "Key";

            int resultIndex;
            if (int.TryParse(_index, out resultIndex))
                cmbChooseIPKey.SelectedIndex = resultIndex;
            else
                cmbChooseIPKey.SelectedIndex = 0;
        }

        private void GetNetworkInformation(bool firstCheck)
        {
            string nicName = firstCheck ? "BaseAddress" : "", ipAddress = "", subnetMask = "", gatewayAddress = "";

            // 현재 IP 주소 불러오기
            try
            {
                // 모든 네트워크 인터페이스 가져오기
                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

                // 각 네트워크 인터페이스에 대해 반복하여 정보 검색
                foreach (NetworkInterface adapter in interfaces)
                {
                    if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet && adapter.OperationalStatus == OperationalStatus.Up)
                    {
                        // 네트워크 인터페이스의 IP 정보 가져오기
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        foreach (UnicastIPAddressInformation ip in properties.UnicastAddresses)
                        {
                            // IPv4 주소만 고려
                            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                // IP 주소
                                ipAddress = ip.Address.ToString();

                                // 서브넷 마스크
                                subnetMask = ip.IPv4Mask.ToString();

                                // 게이트웨이 주소
                                GatewayIPAddressInformation gateway = properties.GatewayAddresses.FirstOrDefault();
                                gatewayAddress = (gateway != null) ? gateway.Address.ToString() : "N/A";

                                break;
                            }
                        }
                    }
                }

                if (firstCheck)
                {
                    config.AppSettings.Settings["NICName0"].Value = nicName;
                    config.AppSettings.Settings["IPAddress0"].Value = ipAddress;
                    config.AppSettings.Settings["Subnet0"].Value = subnetMask;
                    config.AppSettings.Settings["Gateway0"].Value = gatewayAddress;
                    config.Save();

                    _index = "0";
                }
                else
                {
                    var _ipAddress = config.AppSettings.Settings.AllKeys
                                       .Where(key => key.Contains("IPAddress"))
                                       .ToList();
                    foreach (var key in _ipAddress)
                    {
                        if (config.AppSettings.Settings[key].Value == ipAddress)
                        {
                            Match match = Regex.Match(key, @"\d+");
                            if (match != null)
                            {
                                _index = match.Value;

                                break;
                            }
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtAfterIP.Text))
            {
                MessageBox.Show("아이피가 입력되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAfterIP.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtAfterSubnet.Text))
            {
                MessageBox.Show("서브넷이 입력되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAfterSubnet.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtAfterGateway.Text))
            {
                MessageBox.Show("게이트웨이가 입력되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAfterGateway.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtAfterIPKey.Text))
            {
                MessageBox.Show("명칭이 입력되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAfterIPKey.Focus();
                return;
            }

            bool baseSetting = false;
            bool updateConfigYN = false;


            foreach (KeyValuePair<string, string> item in cmbChooseIPKey.Items)
            {
                string beforeValue = item.Value.Trim();

                if (beforeValue.Equals(txtAfterIPKey.Text))
                {
                    if (txtAfterIPKey.Text.Equals("BaseAddress") 
                        && MessageBox.Show("기본 주소는 수정이 불가하고 변경만 진행 합니다. 기본 주소로 변경하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        baseSetting = true;
                        break;
                    }
                    else if (MessageBox.Show("같은 명칭이 존재 합니다 수정하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        updateConfigYN = true;
                        break;
                    }
                }
            }

            bool Result = false;

            //Result = ip.IPChangeRun(this.txtAfterIPKey.Text, this.txtAfterIP.Text, this.txtAfterSubnet.Text, this.txtAfterGateway.Text);
            if (baseSetting)
            {
                // 기본 주소 필드만 할당 하고 기본 주소 실제 적용하기
                Result = true;

                this.txtBeforeIPKey.Text = config.AppSettings.Settings["NICName0"].Value;
                this.txtBeforeIP.Text = config.AppSettings.Settings["IPAddress0"].Value;
                this.txtBeforeSubnet.Text = config.AppSettings.Settings["Subnet0"].Value;
                this.txtBeforeGateway.Text = config.AppSettings.Settings["Gateway0"].Value;

                this.txtAfterIPKey.Text = "";
                this.txtAfterIP.Text = "";
                this.txtAfterSubnet.Text = "";
                this.txtAfterGateway.Text = "";
            }
            else
            {
                // 추가, 수정한 주소 실제 적용하기
                Result = true;
            }

            if (!Result)
            {
                //MessageBox.Show("아이피 정보가 정상적으로 변경되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!baseSetting)
            {
                string rollBackIPKey = this.txtBeforeIPKey.Text;
                string rollBackIP = this.txtBeforeIP.Text;
                string rollBackSubnet = this.txtBeforeSubnet.Text;
                string rollBackGateway = this.txtBeforeGateway.Text;

                string rollBackUpdateIndex = "";

                string commitIPKey = this.txtAfterIPKey.Text;
                string commitIP = this.txtAfterIP.Text;
                string commitSubnet = this.txtAfterSubnet.Text;
                string commitGateway = this.txtAfterGateway.Text;

                string commitIndex = "";

                try
                {
                    if (updateConfigYN)
                    {
                        // 수정 하는 부분
                        var _nicName = config.AppSettings.Settings.AllKeys
                                       .Where(key => key.Contains("NICName"))
                                       .ToList();

                        string updateIndex = "";
                        foreach (var key in _nicName)
                        {
                            if (config.AppSettings.Settings[key].Value == commitIPKey)
                            {
                                Match match = Regex.Match(key, @"\d+");
                                if (match != null)
                                {
                                    updateIndex = match.Value;
                                    break;
                                }
                            }
                        }

                        if (!string.IsNullOrWhiteSpace(updateIndex))
                        {
                            config.AppSettings.Settings["NICName" + updateIndex].Value = commitIPKey;
                            config.AppSettings.Settings["IPAddress" + updateIndex].Value = commitIP;
                            config.AppSettings.Settings["Subnet" + updateIndex].Value = commitSubnet;
                            config.AppSettings.Settings["Gateway" + updateIndex].Value = commitGateway;
                            config.Save(ConfigurationSaveMode.Modified);
                        }
                        else
                        {
                            rollBackUpdateIndex = updateIndex;
                            throw new Exception("수정중 문제가 발생하였습니다.");
                        }
                    }
                    else
                    {
                        // 신규로 추가하는 부분
                        commitIndex = cmbChooseIPKey.Items.Count.ToString();
                        config.AppSettings.Settings.Add("NICName" + commitIndex, commitIPKey);
                        config.AppSettings.Settings.Add("IPAddress" + commitIndex, commitIP);
                        config.AppSettings.Settings.Add("Subnet" + commitIndex, commitSubnet);
                        config.AppSettings.Settings.Add("Gateway" + commitIndex, commitGateway);
                        config.Save(ConfigurationSaveMode.Modified);

                        cmbChooseIPKey.SelectedIndexChanged -= cmbChooseIPKey_SelectedIndexChanged;
                        string newKey = "NICName" + commitIndex;
                        string newValue = commitIPKey;
                        var bindingSource = (BindingSource)cmbChooseIPKey.DataSource;
                        var dataSource = (Dictionary<string, string>)bindingSource.DataSource;
                        dataSource.Add(newKey, newValue);
                        bindingSource.ResetBindings(false);
                        cmbChooseIPKey.DataSource = null;
                        cmbChooseIPKey.DataSource = new BindingSource(dataSource, null);
                        cmbChooseIPKey.SelectedIndexChanged += cmbChooseIPKey_SelectedIndexChanged;
                        cmbChooseIPKey.DisplayMember = "Value";
                        cmbChooseIPKey.ValueMember = "Key";
                        cmbChooseIPKey.SelectedItem = new KeyValuePair<string, string>(newKey, newValue);
                    }

                    this.txtBeforeIPKey.Text = commitIPKey;
                    this.txtBeforeIP.Text = commitIP;
                    this.txtBeforeSubnet.Text = commitSubnet;
                    this.txtBeforeGateway.Text = commitGateway;

                    this.txtAfterIPKey.Text = "";
                    this.txtAfterIP.Text = "";
                    this.txtAfterSubnet.Text = "";
                    this.txtAfterGateway.Text = "";

                    MessageBox.Show("아이피 정보가 정상적으로 변경 되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (updateConfigYN)
                    {
                        config.AppSettings.Settings["NICName" + rollBackUpdateIndex].Value = rollBackIPKey;
                        config.AppSettings.Settings["IPAddress" + rollBackUpdateIndex].Value = rollBackIP;
                        config.AppSettings.Settings["Subnet" + rollBackUpdateIndex].Value = rollBackSubnet;
                        config.AppSettings.Settings["Gateway" + rollBackUpdateIndex].Value = rollBackGateway;
                        config.Save(ConfigurationSaveMode.Modified);
                    }
                    else if (!updateConfigYN)
                    {
                        // 추가일때
                        // 추가한 add 노드 있는지 확인하고 다시 지우기
                        if (config.AppSettings.Settings["NICName" + commitIndex] != null)
                            config.AppSettings.Settings.Remove("NICName" + commitIndex);
                        if (config.AppSettings.Settings["IPAddress" + commitIndex] != null)
                            config.AppSettings.Settings.Remove("IPAddress" + commitIndex);
                        if (config.AppSettings.Settings["Subnet" + commitIndex] != null)
                            config.AppSettings.Settings.Remove("Subnet" + commitIndex);
                        if (config.AppSettings.Settings["Gateway" + commitIndex] != null)
                            config.AppSettings.Settings.Remove("Gateway" + commitIndex);
                        config.Save(ConfigurationSaveMode.Modified);

                        // cmbChooseIPKey 에 추가한 항목 지우고 
                        cmbChooseIPKey.SelectedIndexChanged -= cmbChooseIPKey_SelectedIndexChanged;
                        var bindingSource = (BindingSource)cmbChooseIPKey.DataSource;
                        var dataSource = (Dictionary<string, string>)bindingSource.DataSource;
                        dataSource.Remove("NICName" + commitIndex);
                        bindingSource.ResetBindings(false);
                        cmbChooseIPKey.DataSource = null;
                        cmbChooseIPKey.DataSource = new BindingSource(dataSource, null);
                        cmbChooseIPKey.SelectedIndexChanged += cmbChooseIPKey_SelectedIndexChanged;
                        cmbChooseIPKey.DisplayMember = "Value";
                        cmbChooseIPKey.ValueMember = "Key";

                    }
                    return;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            IPAddressReset();
        }

        private void IPAddressReset()
        {
            if (DialogResult.Yes == MessageBox.Show("BaseAddress로 주소를 복원하고, 등록된 항목들을 모두 삭제합니다.", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                var keyArray = config.AppSettings.Settings.AllKeys.Where(key => !key.Contains("NICName0")
                                                                             && !key.Contains("IPAddress0")
                                                                             && !key.Contains("Subnet0")
                                                                             && !key.Contains("Gateway0")).ToArray();
                foreach (var key in keyArray)
                {
                    config.AppSettings.Settings.Remove(key);
                }

                cmbChooseIPKey.SelectedIndexChanged -= cmbChooseIPKey_SelectedIndexChanged;
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("NICName0", "BaseAddress");
                cmbChooseIPKey.DataSource = null;
                cmbChooseIPKey.DataSource = new BindingSource(dic, null);
                cmbChooseIPKey.DisplayMember = "Value";
                cmbChooseIPKey.ValueMember = "Key";
                cmbChooseIPKey.SelectedIndexChanged += cmbChooseIPKey_SelectedIndexChanged;

                this.txtBeforeIPKey.Text = config.AppSettings.Settings["NICName0"].Value;
                this.txtBeforeIP.Text = config.AppSettings.Settings["IPAddress0"].Value;
                this.txtBeforeSubnet.Text = config.AppSettings.Settings["Subnet0"].Value;
                this.txtBeforeGateway.Text = config.AppSettings.Settings["Gateway0"].Value;
            }
        }

        private void btnDHCP_Click(object sender, EventArgs e)
        {
            //bool Result = ip.IPChangeRun(OrgNICName, "", "", "");

            //if (Result)
            //{
            //    MessageBox.Show("아이피 정보가 정상적으로 변경 되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("아이피 정보가 정상적으로 변경되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void cmbChooseIPKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ComboBox cb = (ComboBox)sender;
            KeyValuePair<string, string> selectedPair = (KeyValuePair<string, string>)cb.SelectedItem;

            if (cb.SelectedIndex >= 0)
            {
                string key = selectedPair.Key;
                string value = selectedPair.Value;

                GetKeyInAddress(key, value);
            }
        }

        private void GetKeyInAddress(string key, string value)
        {
            try
            {
                // App.config에서 저장된 기존 IP 주소 불러오기
                Match match = Regex.Match(key, @"\d+");
                if (match.Success)
                {
                    string index = Convert.ToString(match.Value);
                    if (loadCheck)
                    {
                        txtBeforeIPKey.Text = value;
                        txtBeforeIP.Text = config.AppSettings.Settings["IPAddress" + index].Value;
                        txtBeforeSubnet.Text = config.AppSettings.Settings["Subnet" + index].Value;
                        txtBeforeGateway.Text = config.AppSettings.Settings["Gateway" + index].Value;
                        loadCheck = false;
                    }
                    else
                    {
                        txtAfterIPKey.Text = value;
                        txtAfterIP.Text = config.AppSettings.Settings["IPAddress" + index].Value;
                        txtAfterSubnet.Text = config.AppSettings.Settings["Subnet" + index].Value;
                        txtAfterGateway.Text = config.AppSettings.Settings["Gateway" + index].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
    }
}
