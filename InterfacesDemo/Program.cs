﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3] { new Manager(), new Worker(), new Robot() };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2] { new Manager(), new Worker() };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

            Console.ReadLine();
        }
    }

    interface IWorker
        {
            void Work();
        }
        interface IEat
        {
            void Eat();
        }
        interface ISalary
        {
            void GetSalary();
        }
        class Manager : IWorker, IEat, ISalary
        {
            public void Eat()
            {
            Console.WriteLine("Yöneticiler Yemeğe!");
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
            Console.WriteLine("Yöneticiler İş Başı!");
        }
        }


        class Worker : IWorker, IEat, ISalary
        {
            public void Eat()
            {
            Console.WriteLine("İşçiler Yemeğe!");
        }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
            Console.WriteLine("İşçiler İş Başı!");
        }
        }

        class Robot : IWorker
        {
            public void Work()
            {
            Console.WriteLine("Robotlar çalıştırıldı.");
        }
        }
   
}

