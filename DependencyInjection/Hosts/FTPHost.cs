using System;
using System.Net;
using System.Net.FtpClient;

namespace DependencyInjection.Hosts
{
    internal class FTPHost : Host
    {
        private FtpClient client = new FtpClient();

        public override void Connect()
        {
            client.Host = "127.0.0.1";
            client.Port = 21;
            client.Credentials = new NetworkCredential("user", Password);
            client.Connect();
            IsConnected = true;
        }

        public override void Disconnect()
        {
            if (IsConnected)
            {
                client.Disconnect();
            }
        }
    }
}
