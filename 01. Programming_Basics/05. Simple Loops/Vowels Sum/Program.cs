using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            var sum = 0;
            for (int i = 1; i < inputText.Length; i++)
            {
                if (inputText[i] == 'a') sum += 1; //не слагай "" за сравнение
                else if (inputText[i] == 'e') sum += 2; // числото в [] показва позицията на cимвола от string-a
                else if (inputText[i] == 'i') sum += 3;
                else if (inputText[i] == 'o') sum += 4;
                else if (inputText[i] == 'u') sum += 5;
            }
            Console.WriteLine(sum);
        }
    }
}
