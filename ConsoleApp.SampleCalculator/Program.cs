namespace ConsoleApp.SampleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome Message
            Console.WriteLine("***********  Welcome To The Sample Calculator *************");
            // Show Calculator Options / Show Menu
            
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine();
            Console.Write("Which Calculation do you want to perform ? : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            // Prompt User for Input
            Console.Write("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            

           

            // Decide which operation is needed based on selected option
            // if statements
            //if (choice == 1)
            //{

            //}
            //else if (choice == 2)
            //{

            //}
            //else if (choice == 3)
            //{

            //}
            //else if (choice == 4)
            //{

            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}

            // Decide which operation is needed based on selected option
            // Switch Statements
            int answer = 0;
            switch (choice)
            {
                case 1:
                    answer = num1 + num2;
                    break;
                    case 2:
                    answer = num1 - num2;
                    break;
                    case 3:
                    answer = num1 * num2;
                    break;
                    case 4:
                    answer = num1 / num2;
                    break;
                    default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            // print output
            Console.WriteLine($"The result is: {answer}");
            Console.ReadKey();
        }
    }
}
