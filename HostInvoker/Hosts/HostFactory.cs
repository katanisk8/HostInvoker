using HostHacker;

namespace HostInvoker.Hosts
{
    internal class HostFactory
    {
        private HostFactory() { }

        public static IHost Factory<T>() where T : IHost, new()
        {
            return new T();
        }
    }
}
