using System;
using System.Numerics;

namespace p19InstructionSet
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] codeArgs = command.Split(' ');

                long result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = ++operandOne;
                            Console.WriteLine(result);
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = --operandOne;
                            Console.WriteLine(result);
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + (long)operandTwo;
                            Console.WriteLine(result);
                            break;
                        }
                    case "MLA":
                        {
                            BigInteger num;
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            num = operandOne * (BigInteger)operandTwo;
                            Console.WriteLine(num);
                            break;
                        }
                }
                command = Console.ReadLine();
            }
        }
    }
}