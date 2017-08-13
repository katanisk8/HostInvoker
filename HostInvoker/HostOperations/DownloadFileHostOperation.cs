using System;

namespace HostInvoker.HostOperations
{
    class DownloadFileOperation : HostOperation
    {
        protected override void Run()
        {
            Console.WriteLine("File has been downloaded");
        }
    }
}
