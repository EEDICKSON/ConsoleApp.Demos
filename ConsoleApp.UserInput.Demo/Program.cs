﻿namespace ConsoleApp.UserInput.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and types
            string firstName = string.Empty;
            string lastName = string.Empty;
            int yearOfBirth = 0;
            int currentYear = 2024;
            decimal salary = 0;
            char gender = char.MinValue;
            bool working = false;

            // promt the user for input

            Console.Write("Please enter your First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Please enter your Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Please enter your year of Birth in order to calculate your age: ");
            yearOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your salary: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please enter your gender (M or F): ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Are you working (true or False: ");
            working = Convert.ToBoolean(Console.ReadLine());

            // Process the data
            int age = currentYear - yearOfBirth;


            // Output the results to the user
            Console.WriteLine($"Your Full Name is : {firstName} {lastName}");
            Console.WriteLine($"If you were born in the Year of {yearOfBirth} by Mr.& Mrs. :{lastName}");
            Console.WriteLine($"In the current year : {currentYear} you are {age} years old");
            Console.WriteLine($"Your Salary is : $ {salary} ");
            Console.WriteLine($"Your gender is :{gender}");
            Console.WriteLine($"Your working status is {working}");


            Console.ReadKey();
        }
    }
}
