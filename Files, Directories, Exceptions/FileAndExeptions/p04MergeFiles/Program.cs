using System;
using System.IO;
using System.Text;

namespace p04MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstText = File.ReadAllLines("FileOne.txt");
            string[] secondText = File.ReadAllLines("FileTwo.txt");

            int length = Math.Min(firstText.Length, secondText.Length);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(firstText[i] + Environment.NewLine);
                sb.Append(secondText[i] + Environment.NewLine);
            }
            File.WriteAllText("mergedFiles.txt", sb.ToString());

            if (firstText.Length < secondText.Length)
            {
                for (int i = firstText.Length; i < secondText.Length; i++)
                {
                    File.AppendAllText("mergedFiles.txt", secondText[i] + Environment.NewLine);
                }
            }
            else
            {
                for (int i = secondText.Length; i < firstText.Length; i++)
                {
                    File.AppendAllText("mergedFiles.txt", firstText[i] + Environment.NewLine);
                }
            }

        }
    }
}

