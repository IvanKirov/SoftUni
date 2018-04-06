using System;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();            
            try
            {       // sbyte < byte < short < ushort < int < uint < long
                long isNumber = long.Parse(inputNumber);
                Console.WriteLine($"{inputNumber} can fit in:");
                if (isNumber >= sbyte.MinValue && isNumber <= sbyte.MaxValue)     Console.WriteLine("* sbyte");
                if (isNumber >= byte.MinValue && isNumber <= byte.MaxValue)       Console.WriteLine("* byte");
                if (isNumber >= short.MinValue && isNumber <= short.MaxValue)     Console.WriteLine("* short");
                if (isNumber >= ushort.MinValue && isNumber <= ushort.MaxValue)   Console.WriteLine("* ushort");
                if (isNumber >= int.MinValue && isNumber <= int.MaxValue)         Console.WriteLine("* int");
                if (isNumber >= uint.MinValue && isNumber <= uint.MaxValue)       Console.WriteLine("* uint");
                if (isNumber >= long.MinValue && isNumber <= long.MaxValue)       Console.WriteLine("* long");
            }
            catch (Exception)
            {
                Console.WriteLine("{0} can't fit in any type", inputNumber);
            }
        }
    }
}
