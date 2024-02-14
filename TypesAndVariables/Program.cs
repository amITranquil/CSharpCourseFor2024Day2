using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hey yo!");

            double number5 = 10.9;
            decimal number6 = 11.4m;
            char character = 'a';
            bool condition = true;
            byte number4 = 255;
            short number3 = -32768;
            int number1 = 2147483647;
            long number2 = 21474836471;
            var number7 = 11;
            number7 = 'A';

            Console.WriteLine("First number is {0}", number1);
            Console.WriteLine("Second number is {0}", number2);
            Console.WriteLine("Third number is {0}", number3);
            Console.WriteLine("Fourth number is {0}", number4);
            Console.WriteLine("Condition is ", condition);
            Console.WriteLine("Character is {0}", (int)character);
            Console.WriteLine("Fifth number is {0}", number5);
            Console.WriteLine("Sixth number is {0}", number6);
            Console.WriteLine("Seventh number is {0}", number7);
            Console.WriteLine((int)Days.Friday);

            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
