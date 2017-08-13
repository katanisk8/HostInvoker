using System;
using HostHacker;

namespace DependencyInjection.HostOperations
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
