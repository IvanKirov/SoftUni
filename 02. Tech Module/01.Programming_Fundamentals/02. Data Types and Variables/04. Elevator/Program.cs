using System;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var elevatorCapacity = int.Parse(Console.ReadLine());

            Console.WriteLine((int)Math.Ceiling((double)numberOfPeople / elevatorCapacity));
        }
    }
}
