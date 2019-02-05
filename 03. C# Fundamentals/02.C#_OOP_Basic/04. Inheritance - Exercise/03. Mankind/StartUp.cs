using System;

namespace Mankind
{
    public class StartUp
    {
        public static void Main()
        {
            var inputStudent = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var inputWorker = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            try
            {
                var student = new Student(inputStudent[0], inputStudent[1], inputStudent[2]);
                var worker = new Worker(inputWorker[0], inputWorker[1], decimal.Parse(inputWorker[2]), int.Parse(inputWorker[3]));
                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (Exception exepton)
            {
                Console.WriteLine(exepton.Message);
                return;
            }
        }
    }
}
