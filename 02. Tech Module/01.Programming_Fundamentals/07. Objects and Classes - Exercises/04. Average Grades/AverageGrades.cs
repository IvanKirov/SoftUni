using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Average_Grades
{
    public class AverageGrades
    {
        public static void Main()
        {
            var numberStudents = int.Parse(Console.ReadLine());

            var studentsList = new List<Student>();

            for (int i = 0; i < numberStudents; i++)
            {
                var inputStudent = Console.ReadLine()
                    .Split(' ')
                    .ToList();

                var name = inputStudent[0];
                inputStudent.RemoveAt(0);

                studentsList.Add(new Student
                {
                    Name = name,
                    Grades = inputStudent.Select(double.Parse).ToList()
                });                
            }

            studentsList = studentsList
                .Where(x => x.AverageGrade >= 5)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade)
                .ToList();

            for (int i = 0; i < studentsList.Count; i++)
            {
                Console.WriteLine($"{studentsList[i].Name} -> {studentsList[i].AverageGrade:F2}");
            }
        }
    }
}
