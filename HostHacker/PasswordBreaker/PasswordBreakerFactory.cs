namespace HostHacker
{
    class PasswordBreakerFactory
    {
        private PasswordBreakerFactory() { }

        public static PasswordBreaker Factory<T>() where T : PasswordBreaker, new()
        {
            return new T();
        }
    }
}
