using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p03CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = Console.ReadLine().Split();
            int numberOfElementToSkip = int.Parse(info[0]);
            int numberOfElementToTake = int.Parse(info[1]);
            string input = Console.ReadLine();
            string pattern = @"\b(?<=\|<)(\w+)\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            List<string> validCameras = new List<string>();

            foreach (Match match in matches)
            {
                char[] camera = match.Value.Skip(numberOfElementToSkip).Take(numberOfElementToTake).ToArray();
                string view = new string(camera);
                validCameras.Add(view);
            }

            Console.WriteLine(string.Join(", ",validCameras));
        }
    }
}
