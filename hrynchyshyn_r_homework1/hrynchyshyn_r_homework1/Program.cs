﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace hrynchyshyn_r_homework1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task1

            Console.WriteLine("Write the side of the square: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area square: {0}", a * a);
            int QuantlySideSquare = 4;
            Console.WriteLine("Perimetr square: {0}", a * QuantlySideSquare);
            Console.ReadKey();

            //Task2

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"How old are you, {name}?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Name: {name}, Age: {age}");
            Console.ReadKey();

            //Task3

            Console.WriteLine("Please, write double varible for the radius of a circle: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The length: {0:F1}", 2 * Math.PI * r);
            Console.WriteLine("The area: {0:F1}", Math.PI * r * r);
            Console.WriteLine("The volume: {0:F1}", 4 / 3 * Math.PI * r * r * r);
            Console.ReadKey();
        }


    }
}