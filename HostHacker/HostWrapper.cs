using System;

namespace HostHacker
{
    public class HostWrapper
    {
        private HostWrapper() { }

        public static void BreakHost<T>(IHost host, IHostOperation hostOperation) where T : PasswordBreaker, new()
        {
            try
            {
                Connect(host, PasswordBreakerFactory.Factory<T>());
                InvokeOperation(hostOperation);
            }
            finally
            {
                Disconnect(host);
            }
        }

        private static void Connect(IHost host, PasswordBreaker passwordBreaker)
        {
            passwordBreaker.BreakPassword(host);

            if (host.IsConnected == false)
            {
                throw new Exception("Host cannot be broken");
            }
        }

        private static void Disconnect(IHost host)
        {
            host.Disconnect();
        }

        private static void InvokeOperation(IHostOperation operation)
        {
            operation.Invoke();
        }
    }
}
