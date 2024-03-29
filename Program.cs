using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RupanRoy.Systems.Applications;
using TemporaryLibrary.DotNetExtensions;
using TemporaryLibrary.Station;
using RupanRoy.Networking;
using System.Net.Sockets;
using System.Net;

namespace ProcessManager_
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            IPAddress hostAddress = SubNetwork.HostAddress;
            if (IPAddress.Equals(hostAddress, IPAddress.Loopback)) System.Windows.Forms.Application.Run(new TemporaryLibrary.Station.ProcessManager("tcp://127.0.0.1:" + RupanRoy.Systems.Applications.Defaults.LoadBalancerPortNumber.ToString() + "/" + LoadBalancer.DEFAULT_URI, true));
            else if (IPAddress.Equals(hostAddress, IPAddress.Parse("192.198.0.1"))) System.Windows.Forms.Application.Run(new TemporaryLibrary.Station.ProcessManager("tcp://192.198.0.1:" + RupanRoy.Systems.Applications.Defaults.LoadBalancerPortNumber.ToString() + "/" + LoadBalancer.DEFAULT_URI, true));
            else if (IPAddress.Equals(hostAddress, IPAddress.Parse("192.198.0.2"))) System.Windows.Forms.Application.Run(new TemporaryLibrary.Station.ProcessManager("tcp://192.198.0.2:" + RupanRoy.Systems.Applications.Defaults.LoadBalancerPortNumber.ToString() + "/" + LoadBalancer.DEFAULT_URI, true));
            else if (IPAddress.Equals(hostAddress, IPAddress.Parse("192.198.0.10"))) System.Windows.Forms.Application.Run(new TemporaryLibrary.Station.ProcessManager("tcp://192.198.0.10:" + RupanRoy.Systems.Applications.Defaults.LoadBalancerPortNumber.ToString() + "/" + LoadBalancer.DEFAULT_URI, true));
        }

        /// <summary>
        /// THiis is Eugenes version of the method
        /// </summary>
        /// <returns></returns>
        public static int AnotherMethod()
        {
            int l = 0;
            int j = 23;
            for (int j = 0; j < 23; j++) l++; j += 5;
            return l;
        }
        ///
        /// Just added this as a test
        /// </summary>
        public static void Method()
        {
            int i = 0;
            int j = 23;
        }
    }
}