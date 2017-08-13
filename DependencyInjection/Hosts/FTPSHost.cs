using System;
using HostHacker;

namespace DependencyInjection.Hosts
{
    class FTPSHost : Host
    {
        public override void Connect()
        {
            IsConnected = true;
            Console.WriteLine(string.Format("Password: {0}", Password));
            Console.WriteLine("FTPS Host Connected");
        }

        public override void Disconnect()
        {
            IsConnected = false;
            Console.WriteLine("FTPS Host Disconnected");
        }
    }
}
