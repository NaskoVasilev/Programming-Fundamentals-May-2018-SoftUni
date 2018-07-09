using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p10StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = ReadTowns();
            List<Group> groups = new List<Group>();
            foreach (Town town in towns)
            {
                List<Student> sortedStudents = town.Students
                    .OrderBy(x => x.RegistrationdDate)
                    .ThenBy(x => x.StudentName)
                    .ThenBy(x => x.Mail)
                    .ToList();
                
                while (sortedStudents.Any())
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = sortedStudents.Take(group.Town.Capacity).ToList();
                    sortedStudents = sortedStudents.Skip(group.Town.Capacity).ToList();
                    groups.Add(group);
                }
            }

            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");

            foreach (var group in groups.OrderBy(x=>x.Town.TownName))
            {
                List<string> mails = new List<string>();
                foreach (var student in group.Students)
                {
                    mails.Add(student.Mail);
                }

                Console.WriteLine($"{group.Town.TownName} => {string.Join(", ",mails)}");
            }

        }

        private static List<Town> ReadTowns()
        {
            List<Town> towns = new List<Town>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                if(input.Contains(" => "))
                {
                    string[] tokens = input.Split(" => ");
                    string townName = tokens[0];
                    int seats = int.Parse(tokens[1][0].ToString());
                    Town town = new Town(townName, seats);
                    towns.Add(town);
                }
                else
                {
                    string[] tokens = input.Split('|');
                    string studentName = tokens[0].Trim();
                    string mail = tokens[1].Trim();
                    string dateAsString = tokens[2].Trim();
                    DateTime registartionDate = DateTime.ParseExact(dateAsString, "d-MMM-yyyy",
                        CultureInfo.InvariantCulture);
                    Student student = new Student(studentName, mail, registartionDate);
                    Town currTown = towns.Last();
                    currTown.Students.Add(student);
                }

            }

            return towns;
        }

        class Student
        {
            public Student(string name, string mail, DateTime registrationdDate)
            {
                this.StudentName = name;
                this.Mail = mail;
                this.RegistrationdDate = registrationdDate;
            }

            public string StudentName { get; set; }
            public string Mail { get; set; }
            public DateTime RegistrationdDate { get; set; }
        }

        class Town
        {
            public Town(string townName, int capacity)
            {
                this.TownName = townName;
                this.Capacity = capacity;
                this.Students = new List<Student>();
            }

            public string TownName { get; set; }
            public int Capacity { get; set; }
            public List<Student> Students { get; set; }
        }

        class Group
        {
            public Town Town { get; set; }
            public List<Student> Students { get; set; }
        }

    }
}
