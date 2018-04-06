using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int star = 1;
            star = (n % 2 == 0) ? 2 : star;     // proverka za chetno nechetno bez if
            var tire = (n - star) / 2;          // max tireta
            var blanks = tire - 1;            
            var maxLine = n - star / 2;         // (n-star/2) vadi 1 ot chetnite
            var midLine = n - 2 - 2 * blanks;   // neupotrebyameo, zashtot sedi tuk i e fixirana stoinost!
            for (int red = 1; red <= maxLine; red++)  
            {                
                if (red == 1 || red == (n - star / 2))
                {    //parvi i posleden red                                        
                    Console.WriteLine("{0}{1}{0}", new string('-', tire), new string('*', star));                    
                }
                else if (red > 1 && red <= maxLine / 2 + 1)  //red > 1 && red <= (n - star / 2) / 2 + 1
                {   //srednite redove do sredata, NO nemojesh da imash midLine zashtoto to e fixirana stoinot, ne se promenya
                    Console.WriteLine("{0}*{1}*{0}", new string('-', blanks), new string('-', n - 2 - 2 * blanks)); 
                    blanks--;
                    blanks = (blanks < 0) ? 0 : blanks;                    
                }
                else
                {   // srednite redove sled sredata                    
                    blanks++;
                    Console.WriteLine("{0}*{1}*{0}", new string('-', blanks), new string('-', n - 2 - 2 * blanks));                                       
                }                
            }            
        }
    }
}
