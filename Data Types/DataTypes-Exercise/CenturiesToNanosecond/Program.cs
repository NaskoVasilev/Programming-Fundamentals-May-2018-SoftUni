using System;
using System.Numerics;

namespace CenturiesToNanosecond
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centities = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centities * 100);
            uint days = (uint)(years * 365.2422);
            uint hours = days * 24;
            uint minutes = hours * 60;
            ulong seconds = (ulong)minutes * 60; 
            ulong miliseconds = seconds * 1000;
            ulong microseconds = miliseconds * 1000;
            BigInteger nanoseconds = (BigInteger)microseconds * 1000;
            Console.WriteLine($"{centities} centuries = {years} years = {days} days = {hours} hours" +
                $" = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds " +
                $"= {microseconds} microseconds = {nanoseconds} nanoseconds");

           
        }
    }
}
