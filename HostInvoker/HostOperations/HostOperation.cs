using System;
using HostHacker;

namespace HostInvoker.HostOperations
{
    abstract class HostOperation : IHostOperation
    {
        protected abstract void Run();

        public void Invoke()
        {
            Run();
        }
    }
}
