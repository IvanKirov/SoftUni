using System;

namespace On_Time_for_the_Exam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            var hourExam = byte.Parse(Console.ReadLine());
            var minExam = byte.Parse(Console.ReadLine());
            var hourArrival = byte.Parse(Console.ReadLine());
            var minArrival = byte.Parse(Console.ReadLine());

            var timeArrival = hourArrival * 60 + minArrival;
            var timeExam = hourExam * 60 + minExam;
            var timeRazlika = (timeArrival - timeExam);

            if (timeRazlika < -30)      { Console.WriteLine("Early"); }
            else if (timeRazlika <= 0)  { Console.WriteLine("On time"); }
            else                        { Console.WriteLine("Late"); }

            var hourMore = Math.Abs(timeRazlika / 60);
            var minMore = Math.Abs(timeRazlika % 60);
            
            if (timeRazlika != 0)
            {
                if (hourMore > 0)
                {
                    Console.Write("{0}:{1:00} hours", hourMore, minMore);   // this is better, but not the first chois
                    //if (minutes < 10)
                    //    Console.Write(hours + ":0" + minutes + " hours");
                    //else
                    //    Console.Write(hours + ":" + minutes + " hours");
                }
                else
                {
                    Console.Write(minMore + " minutes");
                }

                if (timeRazlika < 0)
                {
                    Console.WriteLine(" before the start");
                }                
                else
                {
                    Console.WriteLine(" after the start");
                }                
            }            
        }
    }
}
