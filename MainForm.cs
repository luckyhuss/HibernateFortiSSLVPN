using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HibernateFortiSSLVPN
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int WM_APPCOMMAND = 0x319;

        public MainForm()
        {
            InitializeComponent();
        }

        private void radButtonHibernate_Click(object sender, EventArgs e)
        {
            if (radButtonHibernate.Text == "&Hibernate")
            {
                radButtonHibernate.Text = "C&ancel";
                timerHibernate.Start();
            }
            else if (radButtonHibernate.Text == "C&ancel")
            {
                timerHibernate.Stop();
                radButtonHibernate.Text = "&Hibernate";
                numericUpDownHibernateTimeout.Value = 5;
            }
        }

        private void timerHibernate_Tick(object sender, EventArgs e)
        {
            if (numericUpDownHibernateTimeout.Value == 0)
            {
                // reset Hibernate button text
                // stop the timer
                // default timeout value
                radButtonHibernate_Click(sender, e);

                // close SSL VPN client
                radButtonCloseSSLVPN_Click(sender, e);

                if (radCheckBoxMuteSound.Checked)
                {
                    // mute sound before Hibernate
                    MuteWindowsSound();
                }

                // hibernate Windows
                Application.SetSuspendState(PowerState.Hibernate, true, true);                
                return;
            }

            numericUpDownHibernateTimeout.Value -= 1;
        }

        private void radButtonCloseSSLVPN_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("FortiSSLVPNclient"))
            {
                process.Kill();
            }
        }

        private void radButtonOpenSSLVPN_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Fortinet\SslvpnClient\FortiSSLVPNclient.exe");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // check if SSL VPN service is running
            ServiceController sc = new ServiceController("FortiSslvpnDaemon");
            radLabelSSLServiceStatus.Text = String.Format("FortiSslvpnDaemon : {0}", sc.Status);

            // check if SSL VPN client is running
            foreach (var process in Process.GetProcessesByName("FortiSSLVPNclient"))
            {
                radLabelSSLClientStatus.Text = String.Format("FortiSSLVPNclient : {0}", process.Id);
            }
        }

        private void MuteWindowsSound()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        private void radButtonGetLAN_Click(object sender, EventArgs e)
        {
            StringBuilder sbDNSServers = new StringBuilder();
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                IPAddressCollection dnsServers = adapterProperties.DnsAddresses;
                if (dnsServers.Count > 0)
                {
                    foreach (IPAddress dns in dnsServers)
                    {
                        sbDNSServers.AppendLine(String.Format("{0} - {2}",
                            dns.ToString(), adapter.Name, adapter.Description));
                    } // end foreach
                } // end if
            } // end foreach

            MessageBox.Show(sbDNSServers.ToString());
        }

        /// <summary>
        /// Set's the DNS Server of the local machine
        /// </summary>
        /// <param name="NIC">NIC address</param>
        /// <param name="DNS">DNS server address</param>
        /// <remarks>Requires a reference to the System.Management namespace</remarks>
        public void setDNS(string nic, string dns)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    // if you are using the System.Net.NetworkInformation.NetworkInterface you'll need to change this line to if (objMO["Caption"].ToString().Contains(NIC)) and pass in the Description property instead of the name 
                    if (objMO["Description"].Equals(nic))
                    {
                        try
                        {
                            ManagementBaseObject newDNS =
                                objMO.GetMethodParameters("SetDNSServerSearchOrder");
                            
                            if (dns == "," || dns == "") // Empty DNS server
                                newDNS["DNSServerSearchOrder"] = new string[0];
                            else
                                newDNS["DNSServerSearchOrder"] = dns.Split(','); // set DNS server to IPs in list

                            ManagementBaseObject setDNS =
                                objMO.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
        }

        private void radButtonSetLAN_Click(object sender, EventArgs e)
        {
            setDNS("Realtek PCIe FE Family Controller", "208.67.222.222");
        }

        private void radButtonUnsetLAN_Click(object sender, EventArgs e)
        {
            setDNS("Realtek PCIe FE Family Controller", "");
        }
    }
}
