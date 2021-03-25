using System;
using System.Diagnostics;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Hello World";


            //METHOD 1  - BRUTE FORCE (REVERSE ITERATION)
            var s1 = Stopwatch.StartNew();

            //Loop over each array character in reverse
            //text.Length - 1 because of index value starting at 0
            for (var i = text.Length - 1; i>= 0; i--)
            {
                Console.Write($"{text[i]}");
            }
            Console.WriteLine(s1.Elapsed.TotalMilliseconds);


            //METHOD 2 - ARRAY ALLOCATION
            var s2 = Stopwatch.StartNew();

            char[] array = new char[text.Length];
            
            //Iteration Constant
            int forward = 0;

            for(int i = text.Length -1; i>=0; i--)
            {
                //Allocating array slots -> forward and reverse iteration
                array[forward++] = text[i];
            }

            Console.WriteLine(array);
            Console.WriteLine(s2.Elapsed.TotalMilliseconds);

        }
    }
}
