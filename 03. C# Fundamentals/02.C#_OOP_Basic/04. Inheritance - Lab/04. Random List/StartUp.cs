using System;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main()
        {
            RandomList list = new RandomList();

            list.Add("First question");
            list.Add("Second question");
            list.Add("Third question");
            list.Add("Forth question");
            list.Add("Fifth question");
            list.Add("Sixth question");
            list.Add("Seventh question");

            while (list.Count > 0)
            {
                Console.WriteLine(list.GetRandomElement()); 
            }
        }
    }
}
