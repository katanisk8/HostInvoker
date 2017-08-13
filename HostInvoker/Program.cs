using HostInvoker.HostOperations;
using HostInvoker.Hosts;
using HostHacker;
using System;

namespace HostInvoker
{
    class Program
    {
        static void Main(string[] args)
        {
            IHost host = HostFactory.Factory<FTPHost>();

            IHostOperation operation = HostOperationFactory.Factory<DownloadFileOperation>();

            HostWrapper.BreakHost<Bruteforce>(host, operation);

            //Console.ReadLine();
        }
    }
}
