using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\input.txt";
            string[] lines = File.ReadAllLines(path);

            string[] oddLines= lines.Where((line,index)=>index%2==1).ToArray();
            File.WriteAllLines(@"..\..\output.txt",oddLines);
        }
    }
}
