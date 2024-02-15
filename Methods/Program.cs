using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            var result = Add2(96, 66);

            int number1 = 20;
            int number2 = 100;
            //"ref" set value needed but "out" no need firs need to when u are to used set
            var result2 = Add3(ref number1, number2);

            Console.WriteLine(result);
            Console.WriteLine("***************");
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.WriteLine("***************");
            Console.WriteLine("Two numbers multiply -> "+Multiply(5,45));
            Console.WriteLine("Three numbers multiply -> " + Multiply(5,45,10));
            Console.WriteLine("***************");
            Console.WriteLine("Params Sum example -> " + Add4(1,2,3,4,5));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2 = 30)
        {

            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
