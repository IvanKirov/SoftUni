using System;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var nproduct = Console.ReadLine();
            if ( nproduct == "banana" || nproduct == "apple" || nproduct == "kiwi" || nproduct == "cherry" || nproduct == "lemon" || nproduct == "grapes")
            { Console.WriteLine("fruit"); }            
            else if (nproduct == "tomato" || nproduct == "cucumber" || nproduct == "pepper" || nproduct == "carrot")
            { Console.WriteLine("vegetable"); }
            else { Console.WriteLine("unknown"); }
        }
    }
}
