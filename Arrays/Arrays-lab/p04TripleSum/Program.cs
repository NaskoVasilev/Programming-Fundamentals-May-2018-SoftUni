using System;
using System.Linq;

namespace p04TripleSun
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = nums.Length;
            bool isTriple = false;
            for (int i = 0; i < length ; i++)
            {
                for (int j =i+1 ; j < length; j++)
                {
                    for (int k = 0; k <length ; k++)
                    {
                        if(nums[i]+nums[j]==nums[k])
                        {
                            Console.WriteLine($"{nums[i]} + {nums[j]} == {nums[k]}");
                            isTriple = true;
                            break;
                        }
                    }
                }
            }
            if(!isTriple)
            {
                Console.WriteLine("No");
            }
        }
    }
}
