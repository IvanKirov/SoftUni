using System;

namespace _02.Choreography
{
    public class Choreography
    {
        public static void Main()
        {
            var numberOfSteps = int.Parse(Console.ReadLine());
            var dancers = int.Parse(Console.ReadLine());
            var daysToTrain = decimal.Parse(Console.ReadLine());

            var totalStepsPerDay = Math.Ceiling((numberOfSteps / daysToTrain) / numberOfSteps * 100);
            var stepsPerDancer =totalStepsPerDay / dancers;

            if (totalStepsPerDay > 13)
            {
                Console.WriteLine(
                    $"No, They will not succeed in that goal! Required {stepsPerDancer:F2}% steps to be learned per day.");
            }
            else
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsPerDancer:F2}%.");
            }

            //Console.WriteLine(totalStepsPerDay > 13
            //    ? $"No, They will not succeed in that goal! Required {stepsPerDancer:F2}% steps to be learned per day."
            //    : $"Yes, they will succeed in that goal! {stepsPerDancer:F2}%");
        }
    }
}
