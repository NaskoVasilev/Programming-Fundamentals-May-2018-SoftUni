using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] tokens = input.Split(':');
                string command = tokens[0];
                string lessonTitle = "";
                switch (command)
                {
                    case "Add":
                        lessonTitle = tokens[1];
                        if (lessons.Contains(lessonTitle) == false)
                        {
                            lessons.Add(lessonTitle);
                        }
                        break;
                    case "Insert":
                        lessonTitle = tokens[1];
                        int index = int.Parse(tokens[2]);
                        if (index >= 0 && index <= lessons.Count && lessons.Contains(lessonTitle) == false)
                        {
                            lessons.Insert(index, lessonTitle);
                        }
                        break;
                    case "Remove":
                        lessonTitle = tokens[1];
                        if (lessons.Contains(lessonTitle))
                        {
                            lessons.Remove(lessonTitle);
                            string exerciseName = lessonTitle + "-Exercise";
                            if (lessons.Contains(exerciseName))
                            {
                                lessons.Remove(exerciseName);
                            }
                        }
                        break;
                    case "Swap":
                        string firstLessonTitle = tokens[1];
                        string secondLessonTitle = tokens[2]; 
                        string firstLessonExercise = tokens[1]+ "-Exercise"; 
                        string secondLessonExercise = tokens[2]+ "-Exercise";
                        SwapLessons(firstLessonTitle, secondLessonTitle, firstLessonExercise, secondLessonExercise,lessons);
                        break;
                    case "Exercise":
                        lessonTitle = tokens[1];
                        string currentExercise = lessonTitle + "-Exercise";

                        if(lessons.Contains(lessonTitle)&&lessons.Contains(currentExercise)==false)
                        {
                            int lessonIndex = lessons.IndexOf(lessonTitle);
                            lessons.Insert(lessonIndex + 1, currentExercise);
                        }
                        else if (lessons.Contains(lessonTitle)==false)
                        {
                            lessons.Add(lessonTitle);
                            lessons.Add(currentExercise);
                        }
                        break;

                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i+1}.{lessons[i]}");
            }

        }

        private static void SwapLessons(string firstLessonTitle, string secondLessonTitle
            , string firstLessonExercise, string secondLessonExercise, List<string> lessons)
        {
            if (lessons.Contains(firstLessonTitle)&&lessons.Contains(secondLessonTitle))
            {
                int firstLessonIndex = lessons.IndexOf(firstLessonTitle);
                int secondLessonIndex = lessons.IndexOf(secondLessonTitle);
                string tempLesson = lessons[firstLessonIndex];
                lessons[firstLessonIndex] = lessons[secondLessonIndex];
                lessons[secondLessonIndex] = tempLesson;

                if(lessons.Contains(firstLessonExercise)&&lessons.Contains(secondLessonExercise))
                {
                    string tempExercise = lessons[firstLessonIndex + 1];
                    lessons[firstLessonIndex + 1] = lessons[secondLessonIndex + 1];
                    lessons[secondLessonIndex + 1] = tempExercise;
                }
                else if (lessons.Contains(firstLessonExercise))
                {
                    lessons.Remove(firstLessonExercise);
                    lessons.Insert(secondLessonIndex+1, firstLessonExercise);
                }
                else if (lessons.Contains(secondLessonExercise))
                {
                    lessons.Remove(secondLessonExercise);
                    lessons.Insert(firstLessonIndex+1, secondLessonExercise);
                }
            }
        }
    }
}
