using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Hospital
{
    public class Hospital
    {
        public static void Main()
        {
            var departments = new Dictionary<string, List<string>>();
            var doctors = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "Output")
            {                
                var firstIndex = input.IndexOf(' ');
                var lastIndex = input.LastIndexOf(' ');
                var department = input.Substring(0, firstIndex);
                var doctor = input.Substring(firstIndex + 1, lastIndex - firstIndex - 1) ;
                var patient = input.Substring(lastIndex + 1, input.Length - lastIndex - 1);

                if (!departments.ContainsKey(department))
                {
                    departments[department] = new List<string>();
                }
                if (!doctors.ContainsKey(doctor))
                {
                    doctors[doctor] = new List<string>();
                }
                if (departments[department].Capacity < 60)
                {                
                    departments[department].Add(patient);
                    doctors[doctor].Add(patient);
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                string answer;
                if (doctors.ContainsKey(input))
                {
                    answer = string.Join(Environment.NewLine, doctors[input].OrderBy(n => n));
                    Console.WriteLine(answer);
                    continue;
                }
                else if (departments.ContainsKey(input))
                {
                    answer = string.Join(Environment.NewLine, departments[input]);
                    Console.WriteLine(answer);
                    continue;
                }
                else
                {
                    var tokens = input.Split().ToArray();
                    var department = tokens[0];
                    var room = int.Parse(tokens[1]);
                    var patientsInRoom = departments[department].GetRange((room - 1) * 3, 3); 

                    answer = string.Join(Environment.NewLine, patientsInRoom.OrderBy(n => n));
                    Console.WriteLine(answer);
                }

                
            }
        }
    }
}
