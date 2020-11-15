using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Windows.Forms;
namespace InternetLocker
{
    public partial class Form1 : Form
    {

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

            foreach (string adap in interfacesList.CheckedItems)
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

        private void enAllBtn_Click(object sender, EventArgs e)
        {
            enableAll();
        }

        private void disAllBtn_Click(object sender, EventArgs e)
        {
            disableAll();
        }

        private void Enable(string interfaceName)
        {

            ProcessStartInfo psi =
                   new ProcessStartInfo("CMD.exe", "/C netsh interface set interface \"" + interfaceName + "\" Enable");
            psi.Verb = "runas";
            psi.FileName = "cmd.exe";
            if (!cmd.Checked)
            {
                psi.WindowStyle = ProcessWindowStyle.Hidden;

            }
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            if (!cmd.Checked)
            {
                p.WaitForExit();
            }

        }
        private void Disable(string interfaceName)
        {

            ProcessStartInfo psi =
                   new ProcessStartInfo("CMD.exe", "/C  netsh interface set interface \"" + interfaceName + "\" Disable");
            psi.Verb = "runas";
            psi.FileName = "cmd.exe";
            {
                psi.WindowStyle = ProcessWindowStyle.Hidden;

            }
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            if (!cmd.Checked)
            {
                p.WaitForExit();
            }


        }

        private void enableAll()
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
            if (!cmd.Checked)
            {
                psi.WindowStyle = ProcessWindowStyle.Hidden;

            }
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            if (!cmd.Checked)
            {
                p.WaitForExit();
            }


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


    }
}
