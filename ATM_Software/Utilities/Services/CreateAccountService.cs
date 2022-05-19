using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Utilities.Services
{
    public class CreateAccountService
    {

        public static bool CreateAccount()
        {
            return false;
        }

        public static long GenerateAccountNumber()
        {
            var timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            Console.WriteLine(@"Timestamp: {0}", timestamp);

            return timestamp;
        }
    }
}
