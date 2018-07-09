using System;

namespace PadwanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int numberOfSabers = (int)Math.Ceiling(countOfStudents * 1.1);
            int numberOfBelts = countOfStudents - countOfStudents / 6;

            double equipmentPrice = lightsaberPrice * numberOfSabers
                + countOfStudents * robePrice
                + numberOfBelts * beltPrice;

            if(equipmentPrice>currentMoney)
            {
                Console.WriteLine($"Ivan Cho will need {equipmentPrice-currentMoney:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {equipmentPrice:f2}lv.");
            }

        }
    }
}
