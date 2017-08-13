namespace HostHacker
{
    public abstract class PasswordBreaker
    {
        public void BreakPassword(IHost host)
        {
            while (host.IsConnected == false)
            {
                host.Password = CalculatePassword();

                try
                {
                    host.Connect();
                }
                catch (System.Exception) { }
            }
        }

        protected abstract string CalculatePassword();
    }
}
