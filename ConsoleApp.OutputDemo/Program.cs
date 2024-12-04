﻿namespace ConsoleApp.OutputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Eric Edwin Dickson";
            int age = 30;
            int retirementYearsLeft = 30;
            string greetings = "Hello, my name is ";


            Console.WriteLine(greetings + name + " my age is " + age); // string concatenation
            Console.WriteLine($"Hello, my name is {name}"); // string interpolation
            Console.WriteLine("Hello, my name is {0}", name); // Formatted string



            Console.ReadKey();
        }
    }
}

