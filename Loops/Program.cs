using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //Console.WriteLine("\n***************\n");
            //WhileLoop();
            //Console.WriteLine("\n***************\n");
            //DoWhileLoop();
            //Console.WriteLine("\n***************\n");
            //ForEachLoop();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            if (IsPrimeNumber(10000000)) 
            {
                Console.WriteLine("Prime Number!");
            }
            else
            {
                Console.WriteLine("Not a Prime Number!");
            }
            stopwatch.Stop();
            Console.WriteLine($"For döngüsü {stopwatch.ElapsedMilliseconds} milisaniye sürdü.");
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }

        private static void ForEachLoop()
        {
            string[] students = new string[] { "Engin", "Derin", "Nadir" };
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
            Console.WriteLine("Finished Do While!");
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number = number - 1;
            }
            Console.WriteLine("Finished While!");
            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished Loop!");
        }
    }
}
