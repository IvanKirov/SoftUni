using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Lekcia
{
    public class Lekcia
    {
        public static void Main()
        {
            var dictionary = new Dictionary<string, int>();

            dictionary["Pesho"] = 5;    // ne felva add stava samo 1 posle garmi
            dictionary["Ivan"] = 4;
            dictionary["Maria".ToLower()] = 2;

            int number = 0;
            bool valueExists = dictionary.TryGetValue("Gosho", out number);

            bool exists = dictionary.ContainsKey("Maria");

            if (dictionary.ContainsKey("Pesho"))
            {
                Console.WriteLine(dictionary["Pesho"]);
            }

            var phones = new Dictionary<string, string>();

            phones["Pesho"] = "+359 888 888 888";

            var marks = new Dictionary<string, List<int>>();
            marks["Ivan"] = new List<int>
            {
                6, 6, 6
            };

            int number = 0;
            string text = Console.ReadLine();
            bool parsed = int.TryParse(text, out number);
        }
    }
}