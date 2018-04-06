using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08.MentorGroup
{
    public class MentorGroup
    {
        public static void Main()
        {
            var inputText = string.Empty;

            var studentList = new List<Students>();

            while ((inputText = Console.ReadLine()) != "end of dates")
            {
                var studentsInfo = inputText
                    .Split(' ', ',')
                    .ToArray();

                var name = studentsInfo[0];

                if (!studentList.Any(n => n.Name == name))
                {
                    var newStudent = new Students();
                    newStudent.Name = name;
                    newStudent.AttendencyDates = new List<DateTime>();
                    newStudent.Comments = new List<string>();
                    foreach (var date in studentsInfo.Skip(1))
                    {
                        var day = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        newStudent.AttendencyDates.Add(day);
                    }

                    studentList.Add(newStudent);                    
                }
                else
                {
                    var studentIndex = studentList.FindIndex(n => n.Name == name);
                    
                    foreach (var date in studentsInfo.Skip(1))
                    {
                        var day = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        studentList[studentIndex].AttendencyDates.Add(day);
                    }
                }
            }

            while ((inputText = Console.ReadLine()) != "end of comments")
            {
                var studentInput = inputText
                    .Split('-')
                    .ToArray();

                var studentName = studentInput[0];
                var comments = studentInput[1];

                if (studentList.Any(n => n.Name == studentName))
                {
                    var studentIndex = studentList.FindIndex(c => c.Name == studentName);
                    studentList[studentIndex].Comments.Add(comments);
                }
            }
                        
            foreach (var student in studentList.OrderBy(n => n.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");

                var studentIndex = studentList.FindIndex(n => n.Name == student.Name);

                foreach (var comment in studentList[studentIndex].Comments)
                {
                    Console.WriteLine($" - {comment}");
                }

                Console.WriteLine("Dates attended:");
                
                foreach (var date in studentList[studentIndex].AttendencyDates.OrderBy(d => d.Date))
                {
                    Console.WriteLine($" -- {date:dd/MM/yyyy}");
                }
            }
        }
    }
}
