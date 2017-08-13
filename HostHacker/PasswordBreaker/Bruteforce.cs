using System.Linq;

namespace HostHacker
{
    public class Bruteforce : PasswordBreaker
    {
        string  chars = "~!@#$%^&*()_+`1234567890-=qwertyuiop[]\asdfghjkl;'zxcvbnm,./QWERTYUIOP{}|ASDFGHJKL:\"ZXCVBNM<>?";

        
        protected override string CalculatePassword()
        {
            var chaxrs = Enumerable.Range(0, char.MaxValue + 1)
                         .Select(i => (char)i)
                         .Where(c => char.IsSymbol(c))
                         .ToArray();




            return chars[0].ToString();
        }
    }
}
