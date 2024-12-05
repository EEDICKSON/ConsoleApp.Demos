namespace ConsoleApp.OutputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 - 7 to tell the day of the week : "); 

            int day = Convert.ToInt32(Console.ReadLine());

            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid Input");
            }
            else if (day == 1)
            {
                Console.WriteLine("Sunday");
            }
            else if (day == 2)
            {
                Console.WriteLine("Monday");
            }
            else if (day == 3)
            {
                Console.WriteLine("Tuesday");
            }
            else if (day == 4)
            {
                Console.WriteLine("Wednesday (Hump Day!");
            }
            else if (day == 5)
            {
                Console.WriteLine("Thursday");
            }
            else if (day == 6)
            {
                Console.WriteLine("Friday (TGIF)");
            }
            else if (day == 7)
            {
                Console.WriteLine("Saturday (Beach Day)");
            }
            Console.ReadKey();
        }
    }
}

