using DependencyInjection.HostOperations;
using DependencyInjection.Hosts;
using HostHacker;
using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IHost host = HostFactory.Factory<FTPHost>();

            IHostOperation operation = HostOperationFactory.Factory<DownloadFileOperation>();

            HostWrapper.BreakHost<Bruteforce>(host, operation);

            Console.ReadLine();
        }
    }
}
