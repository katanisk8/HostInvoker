using System;
using HostHacker;

namespace HostInvoker
{
    internal class UploadFileFileOperation : IHostOperation
    {
        public void Invoke()
        {
            Console.WriteLine("File has been uploaded");
        }
    }
}
