using System;
using System.Collections.Generic;

namespace _04.Fix_Emails
{
    public class FixEmails
    {
        public static void emailVerification(string input, Dictionary<string, string> emailsDictionary)
        {
            string email = Console.ReadLine();
            var domain = email.Substring(email.Length - 2);
            
            if (domain != "uk" && domain != "us")
            {
                emailsDictionary[input] = email;
            }
        }

        public static void Main()
        {

            var emailsDictionary = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                else if (!emailsDictionary.ContainsKey(input))
                {
                    emailVerification(input, emailsDictionary);
                }
                else if (emailsDictionary.ContainsKey(input))
                {
                    emailVerification(input, emailsDictionary);
                }
            }

            foreach (var item in emailsDictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }        
    }
}
