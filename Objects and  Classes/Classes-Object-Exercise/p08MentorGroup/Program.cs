using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p08MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            string input = Console.ReadLine();

            while (input!= "end of dates")
            {
                string[] tokens = input.Split();
                string name = tokens[0];
                if(tokens.Length==1)
                {
                    Student student = new Student();
                    students.Add(name, student);
                    input = Console.ReadLine();
                    continue;
                }
                List<DateTime>listOfDates = tokens[1].Split(',')
                    .Select(x=>DateTime.ParseExact(x,"dd/MM/yyyy"
                    ,CultureInfo.InvariantCulture))
                    .ToList();

                if(students.ContainsKey(name)==false)
                {
                    Student student = new Student();
                    students.Add(name,student);
                }
                students[name].AttendanceDates.AddRange(listOfDates);

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();
            while (command != "end of comments")
            {
                string[] tokens = command.Split('-');
                string name = tokens[0];
                if(tokens.Length==1)
                {
                    command = Console.ReadLine();
                    continue;
                }
                string comment = tokens[1];

                if (students.ContainsKey(name) == false)
                {
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    students[name].Comments.Add(comment);
                }

                command = Console.ReadLine();
            }

            foreach (var student in students.OrderBy(x=>x.Key))
            {
                
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");
                foreach (var date in student.Value.AttendanceDates.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture)}");
                }
            }

        }

        class Student
        {
            public List<string> Comments { get; set; }
            public List<DateTime> AttendanceDates { get; set; }

            public Student()
            {
                this.Comments = new List<string>();
                this.AttendanceDates = new List<DateTime>();
            }
        }
    }
}
