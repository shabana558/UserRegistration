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
            
            Console.WriteLine("Validating Email Address");
            ValidatingEmailId();

        }
        public void ValidatingEmailId()
        {
            string emailPattern = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
            Regex regex = new Regex(emailPattern);
            Console.WriteLine("Enter email Id");
            string emails = Console.ReadLine();
            bool res = regex.IsMatch(emails);
            if (res)
            {
                Console.WriteLine("valid email address");
            }
            else
            {
                Console.WriteLine("Please enter a Valid Email!");
            }
        }
    }
}
