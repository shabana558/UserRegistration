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
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input1 = Console.ReadLine();
            ValidatingEmailId(input1);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input2 = Console.ReadLine();
            ValidatingEmailId(input2);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input3 = Console.ReadLine();
            ValidatingEmailId(input3);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input4 = Console.ReadLine();
            ValidatingEmailId(input4);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input5 = Console.ReadLine();
            ValidatingEmailId(input5);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input6 = Console.ReadLine();
            ValidatingEmailId(input6);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input7 = Console.ReadLine();
            ValidatingEmailId(input7);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input8 = Console.ReadLine();
            ValidatingEmailId(input8);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input9 = Console.ReadLine();
            ValidatingEmailId(input9);
        }
        public static string ValidatingEmailId(string email)
        {
           string emailPattern = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
            Regex regex = new Regex(emailPattern);
            // for (int i = 0; i < emailInput.Length; i++)
            //{
            bool result = regex.IsMatch(email);
            if (result)
            {
                Console.WriteLine(email + "------->valid");
                return email;
            }
            else
            {
                Console.WriteLine(email + "----->Invalid");
            }

            return default;
        }
    }
}

       
        

    

    

