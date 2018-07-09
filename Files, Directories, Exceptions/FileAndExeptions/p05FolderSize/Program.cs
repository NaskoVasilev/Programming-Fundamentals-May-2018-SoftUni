using System;
using System.IO;

namespace p05FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("TestFolder");
            double sum = 0;

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                sum += info.Length;
            }
            double sizeInMb = Math.Round(sum / 1024.00, 5);
            File.WriteAllText("size.txt", sizeInMb.ToString());
        }
    }
}
