using HostHacker;

namespace DependencyInjection.Hosts
{
    abstract class Host : IHost
    {
        public bool IsConnected { get; protected set; }
        public string Password { get; set; }

        public Host()
        {
            IsConnected = false;
        }

        public abstract void Connect();

        public abstract void Disconnect();
    }
}
