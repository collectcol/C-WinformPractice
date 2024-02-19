using System;
using System.Management;
using System.Windows.Forms;

namespace sin_IPChange
{
    internal class IPChange
    {
        public bool IPChangeRun(string nicDescription, string ipAddress, string subnetMask, string gateway)
        {
            ManagementClass adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection networkCollection = adapterConfig.GetInstances();

            foreach (ManagementObject adapter in networkCollection)
            {
                string description = adapter["Description"] as string;
                if (string.Compare(description, nicDescription, StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    try
                    {
                        ManagementBaseObject newAddress = adapter.GetMethodParameters("EnableStatic");
                        newAddress["IPAddress"] = new string[] { ipAddress };
                        newAddress["SubnetMask"] = new string[] { subnetMask };

                        // IP 주소 및 서브넷 마스크 설정
                        adapter.InvokeMethod("EnableStatic", newAddress, null);

                        // 게이트웨이 설정 (만약 게이트웨이 값이 제공되었다면)
                        if (!string.IsNullOrEmpty(gateway))
                        {
                            ManagementBaseObject newGateway = adapter.GetMethodParameters("SetGateways");
                            newGateway["DefaultIPGateway"] = new string[] { gateway };
                            newGateway["GatewayCostMetric"] = new int[] { 1 };

                            adapter.InvokeMethod("SetGateways", newGateway, null);
                        }

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
