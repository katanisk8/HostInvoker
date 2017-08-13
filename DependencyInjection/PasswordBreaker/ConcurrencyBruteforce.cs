using HostHacker;

namespace DependencyInjection
{
    class ConcurrencyBruteforce : PasswordBreaker
    {
        protected override string CalculatePassword()
        {
            return "12345";
        }
    }
}
