namespace ConsoleApp.UserInput.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string firstName = string.Empty;
            string lastName = string.Empty;
            int yearOfBirth = 0;
            int currentYear = 2024;
            int age = 0;

            // promt user for input

            Console.WriteLine("Please enter your First Name");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your Last Name");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your year of Birth in order to calculate your age");
            yearOfBirth = Convert.ToInt32(Console.ReadLine());

            age = currentYear - yearOfBirth;

            Console.WriteLine($"Your Full Name is : {firstName} {lastName}");
            Console.WriteLine($"If you were born in the Year of {yearOfBirth} by Mr.& Mrs. :{lastName}");
            Console.WriteLine($"In the current year {currentYear} you are {age} years old");


            Console.ReadKey();
        }
    }
}
