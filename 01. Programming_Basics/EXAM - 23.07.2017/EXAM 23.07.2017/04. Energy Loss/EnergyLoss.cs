using System;

namespace _04.Energy_Loss
{
    public class EnergyLoss
    {
        public static void Main()
        {
            var trainingDays = byte.Parse(Console.ReadLine());
            var dancers = int.Parse(Console.ReadLine());

            int usedEnergy = 0;
            for (int i = 1; i <= trainingDays; i++)
            {
                var trainingHours = byte.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    if (trainingHours % 2 == 0)
                    {
                        usedEnergy += dancers * 68;
                    }
                    else
                    {
                        usedEnergy += dancers * 65;
                    }
                }
                else
                {
                    if (trainingHours % 2 == 0)
                    {
                        usedEnergy += dancers * 49;
                    }
                    else
                    {
                        usedEnergy += dancers * 30;
                    }
                }
            }

            var totalDancersPower = 100 * dancers * trainingDays;
            var totalUnspentEnergy = totalDancersPower - usedEnergy;
            var dancerPowerLeft = totalUnspentEnergy / (decimal)dancers / trainingDays;

            if (dancerPowerLeft > 50)
            {
                Console.WriteLine($"They feel good! Energy left: {dancerPowerLeft:F2}");
            }
            else
            {
                Console.WriteLine($"They are wasted! Energy left: {dancerPowerLeft:F2}");
            }
        }
    }
}
