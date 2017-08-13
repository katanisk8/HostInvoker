using System;

namespace DependencyInjection.HostOperations
{
    class DownloadFileOperation : HostOperation
    {
        protected override void Run()
        {
            Console.WriteLine("File has been downloaded");
        }
    }
}
