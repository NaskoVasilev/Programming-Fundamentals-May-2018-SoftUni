using System;
using System.Collections.Generic;
using System.Linq;

namespace p04AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            Student[] students = new Student[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                string info = Console.ReadLine();
                students[i] = ReadStudent(info);
            }

            foreach (Student student in students.OrderBy(x => x.Name).ThenByDescending(x => x.Average))
            {
                if(student.Average>=5.00)
                {
                    Console.WriteLine($"{student.Name} -> {student.Average:f2}");
                }
            }
        }

        class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double Average
            {
                get
                {
                    return Grades.Average();
                }
            }



        }

        static Student ReadStudent(string input)
        {
            Student student = new Student();
            string[] info = input.Split();
            string name = info[0];
            List<double> grades = new List<double>();

            for (int i = 1; i < info.Length; i++)
            {
                grades.Add(double.Parse(info[i]));
            }
            student.Name = name;
            student.Grades = grades;
            return student;
        }
    }
}
