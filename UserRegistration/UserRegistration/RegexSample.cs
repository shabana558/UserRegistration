using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    internal class RegexSample
    {

        string pattern = "^[A-Za-z]{2,}$";

        public void Validating()
        {
            Regex regex = new Regex(pattern);

            Console.WriteLine("Validating password");
            ValidatingPassWord();

        }

        public void ValidatingPassWord()
        {
            string passwordPattern = @"[a-z,A-Z,0-9]{8,}$";
            Regex regex = new Regex(passwordPattern);
            Console.WriteLine("Enter password minimum 8 characters");
            string password = Console.ReadLine();
            bool res = regex.IsMatch(password);
            if (res)
            {
                Console.WriteLine("Password valid");
            }
            else
            {
                Console.WriteLine("invalid password");
            }

        }
    }
}
