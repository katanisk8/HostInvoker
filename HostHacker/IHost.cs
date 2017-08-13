namespace HostHacker
{
    public interface IHost
    {
        void Connect();
        void Disconnect();
        string Password { get; set; }
        bool IsConnected { get; }
    }
}
