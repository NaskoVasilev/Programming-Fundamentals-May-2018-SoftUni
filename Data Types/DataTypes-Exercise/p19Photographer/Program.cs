using System;

namespace p19Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPhotos = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int timeForUploaded = int.Parse(Console.ReadLine());
            int filteredPhotos = (int)(Math.Ceiling(numberOfPhotos * (filterFactor / 100.0)));
            int filterTimeForPhotos = numberOfPhotos * filterTime;
            int uploadedTimeForPhotos = filteredPhotos * timeForUploaded;
            int totalTime = filterTimeForPhotos + uploadedTimeForPhotos;
            int days = totalTime / (24 * 60 * 60);
            int hours = (totalTime  % (24*60*60))/3600;
            int minutes = (totalTime % (24 * 60 * 60) % (3600)) / 60;
            int seconds = (totalTime % (24 * 60 * 60) % (3600)) % 60;
            Console.WriteLine($"{days:D1}:{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
