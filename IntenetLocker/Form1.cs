using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Management.Infrastructure;
using System.Net.NetworkInformation;
using System.Diagnostics;
namespace IntenetLocker
{
    public partial class Form1 : Form
    {
        //private const string InterfaceName = "wifi";
        //private static string strCmdText = "netsh interface set interface \"" + InterfaceName + "\" ";
        private static NetworkInterface[] list = NetworkInterface.GetAllNetworkInterfaces();

        public Form1()
        {
            InitializeComponent();
            
            for (int i = 0; i < list.Length; i++)
            {
                interfacesList.Items.Add(list[i].Name);
            }
            

        }

        private void enableBtn_Click(object sender, EventArgs e)
        {
            
            foreach(string adap in interfacesList.CheckedItems)
            {
                Enable(adap);
            }
            
        }

        private void disableBtn_Click(object sender, EventArgs e)
        {
            foreach (string adap in interfacesList.CheckedItems)
            {
                Disable(adap);
            }
        }

        static void Enable(string interfaceName)
        {
            ProcessStartInfo psi =
                   new ProcessStartInfo("CMD.exe", "/C netsh interface set interface \""+interfaceName+"\" Enable");
            psi.Verb = "runas";
            psi.FileName = "cmd.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();

        }

        static void enableAll()
        {
            string com = "";
            foreach (NetworkInterface adap in list)
            {
                com += "netsh interface set interface \"" + adap.Name + "\" Enable&";
            }
            ProcessStartInfo psi =
                   new ProcessStartInfo("CMD.exe", "/K" + com);
            psi.Verb = "runas";
            psi.FileName = "cmd.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            //p.WaitForExit();

        }

        static void disableAll()
        {
            string com = "";
            foreach (NetworkInterface adap in list)
            {
                com += "netsh interface set interface \"" + adap.Name + "\" Disable&";
            }
            ProcessStartInfo psi =
                   new ProcessStartInfo("CMD.exe", "/K " + com);
            psi.Verb = "runas";
            psi.FileName = "cmd.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            //p.WaitForExit();
        }

        static void Disable(string interfaceName)
        {

            ProcessStartInfo psi =
                   new ProcessStartInfo("CMD.exe", "/C  netsh interface set interface \"" + interfaceName + "\" Disable");
            psi.Verb = "runas";
            psi.FileName = "cmd.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();

            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = strCmdText + " Disable";
            //startInfo.Verb = "runas";
            //process.StartInfo = startInfo;
            //process.Start();
        }

        static void QueryInstanceFunc()
        {
            CimSession session = CimSession.Create("localHost");
            IEnumerable<CimInstance> queryInstance = session.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_NetworkAdapter");

            foreach (CimInstance cimObj in queryInstance)
            {
                Console.WriteLine(cimObj.CimInstanceProperties["Name"].ToString());
                Console.WriteLine(cimObj.CimInstanceProperties["Description"].ToString());
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private void enAllBtn_Click(object sender, EventArgs e)
        {
            enableAll();
        }

        private void disAllBtn_Click(object sender, EventArgs e)
        {
            disableAll();
        }
    }
}
