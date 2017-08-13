﻿using System;
using HostHacker;

namespace DependencyInjection
{
    internal class UploadFileFileOperation : IHostOperation
    {
        public void Invoke()
        {
            Console.WriteLine("File has been uploaded");
        }
    }
}
