using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10.Student_Groups
{
    public class StudentGroups
    {
        public static List<Town> ReadTownsAndStudents()
        {
            var towns = new List<Town>();

            var inputText = string.Empty;

            while ((inputText= Console.ReadLine()) != "End")
            {
                if (inputText.Contains("=>"))   // input town
                {
                    var arrayText = inputText
                        .Split(new[] { " => " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    var newTown = new Town();
                    newTown.Name = arrayText[0];
                    newTown.SeatsCount = int.Parse(arrayText[1].Split(' ')[0]);
                    newTown.Students = new List<Student>();
                    towns.Add(newTown);
                }
                else                             // input students
                {
                    var arrayText = inputText
                        .Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    var newStudent = new Student();
                    newStudent.Name = arrayText[0] + " " + arrayText[1];
                    newStudent.Email = arrayText[2];
                    newStudent.RegistrationDate = DateTime
                        .ParseExact(arrayText[3], "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    towns[towns.Count - 1].Students.Add(newStudent);  // add a new student to the last town
                }
            }

            return towns;
        }

        public static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (var town in towns.OrderBy(x => x.Name))
            {
                IEnumerable<Student> students = town.Students
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(n => n.Name)
                    .ThenBy(e => e.Email);

                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }

            return groups;
        }

        public static void Main()
        {
            var tokens = ReadTownsAndStudents();

            var result = DistributeStudentsIntoGroups(tokens);

            var numberTowns = result
                .Select(a => a.Town)
                .Distinct()
                .ToList()
                .Count;

            Console.WriteLine($"Created {result.Count} groups in {numberTowns} towns:");

            foreach (var group in result)
            {
                Console.WriteLine($"{group.Town.Name} => {string.Join(", ", group.Students.Select(a => a.Email).ToList())}");
            }
        }

        
    }
}

