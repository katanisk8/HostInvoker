﻿using HostHacker;

namespace HostInvoker.HostOperations
{
    internal class HostOperationFactory
    {
        public static IHostOperation Factory<T>() where T : IHostOperation, new()
        {
            return new T();
        }
    }
}
