using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double granica = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double div = Proc(lastPrice, currentPrice); bool isSignificantDifference = imaliDif(div, granica);
            string message = Get(currentPrice, lastPrice, div, isSignificantDifference);
            Console.WriteLine(message);
            lastPrice = currentPrice;
        }
    }

    private static string Get(double currentPrice, double lastPrice, double razlika, bool etherTrueOrFalse)
    {
        string to = "";
        if (razlika == 0)
        {
            to = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, razlika);
        }
        else if (etherTrueOrFalse && (razlika > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, razlika);
        }
        else if (etherTrueOrFalse && (razlika < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, razlika);
        return to;
    }

    private static bool imaliDif(double granica, double isDiff)
    {
        if (Math.Abs(granica) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double Proc(double l, double currentPrice)
    {
        double r = (currentPrice - l) / l;
        return r;
    }
}
