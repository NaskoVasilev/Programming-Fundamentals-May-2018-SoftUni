using System;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            int timeNeeded = 0;
            
            int answeredQuestionsPerHour = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;

            while (countOfStudents > 0)
            {
                countOfStudents -= answeredQuestionsPerHour;
                timeNeeded++;
                if(timeNeeded%4==0)
                {
                    timeNeeded++;
                }
            }
            
            Console.WriteLine($"Time needed: {timeNeeded}h.");
        }
    }
}
