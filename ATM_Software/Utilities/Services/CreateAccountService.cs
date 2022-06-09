using ATM_Software.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Utilities.Services
{
    public class CreateAccountService
    {

        public static bool CreateAccount(BankAccountModel bankAccountModel)
        {
            return false;
        }

        public static string GenerateLoginId()
        {
            var RandomObj = new Random();

            var loginID = "";

            // adding first two capital letter
            for (int i = 0; i < 2; i++)
            {
                loginID += (char)RandomObj.Next(65, 90);
            }

            // adding last one small letter
            for (int i = 0; i < 1; i++)
            {
                loginID += (char)('a' + RandomObj.Next(0, 26));
            }

            // adding a dash and 4 digits after first three letters 
            loginID = loginID + "-" + RandomObj.Next(1111, 9999);

            return loginID;

        }

        public static string GeneratePincode()
        {
            var randomObj = new Random();

            var pinCodeLength = 5;
            var chars = new char[pinCodeLength];

            // adding two small digits
            for (int i = 0; i < 2; i++)
            {
                chars[i] = (char) ('a' + randomObj.Next(0, 26));
            }

            // adding two large digits
            for (int i = 2; i < 4; i++)
            {
                chars[i] = (char)('A' + randomObj.Next(0, 26));
            }

            // adding one @ sign and one single digits
            var newPassword = new string(chars) + "@" +randomObj.Next(0, 9);

            return new string(newPassword);
        }

        public static long GenerateAccountNumber()
        {
            var timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            Console.WriteLine(@"Timestamp: {0}", timestamp);

            return timestamp;
        }
    }
}
