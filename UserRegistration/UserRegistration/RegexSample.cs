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

            Console.WriteLine("Validating Phone Number");
            ValidatingPhoneNum();

        }

        public void ValidatingPhoneNum()
        {
            string phoneNumPattern = @"^[0-9]+[\s]+[0-9]{10}$";
            Regex regex = new Regex(phoneNumPattern);
            Console.WriteLine("Enter valid Phone Number");
            string phoneNumber = Console.ReadLine();
            bool res = regex.IsMatch(phoneNumber);
            if (res)
            {
                Console.WriteLine("valid phone Number");
            }
            else
            {
                Console.WriteLine("Please enter a Valid phone Number!");
            }

        }
    }
}
