using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Salih";
            students[1] = "Derin";
            students[2] = "Engin";

            string[] students2 = new[] { "Engin", "Salih", "Derin" };


            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("\n***************\n");
            foreach (string student in students2)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("\n***************\n");
            string[,] regions = new string[7, 3]
            {
                {"İstanbul","Kocaeli","Tekirdağ" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" },
                {"Van","Iğdır","Kars" },
                {"Şırnak","Hakkari","Mardin" }
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);

                }
                Console.WriteLine("***************");

            }
            Console.ReadLine();
        }
    }
}
