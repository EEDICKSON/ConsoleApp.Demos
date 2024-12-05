namespace ConsoleApp.ConditionsAndDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // prompt for input
            Console.Write("Please Enter Student's grade : ");
            int grade = Convert.ToInt32(Console.ReadLine());


            // Simple If.... Else....statement - Decide to print pass or fail based on input
            Console.WriteLine("*****************  SIMPLE IF RESULTS *********************");
            if (grade > 50)
            {
                Console.WriteLine("Student has Passed");
            }
            else
            {
                Console.WriteLine("Student has Failed");
                Console.WriteLine("Student Should Be Re-Evaluated");
            }
            Console.WriteLine("***************  SIMPLE IF RESULTS END  *****************");

            
            
            // Complex If ...Else if...statement - Decide to print letter based on your value
            Console.WriteLine("***************  SIMPLE IF RESULTS END  *****************");
            /*  A	90% - 100%
                B	80% - 89%
                C	70% - 79%
                D	60% - 69%
                F	0% - 59%  
            */
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid Value Entered");
            }
            else if (grade < 59)
            {
                Console.WriteLine("Student has failed - F");
            }
            else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine("D");
            }
            else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("A");
            }


            Console.WriteLine("*************  COMPLEX IF.. ELSE IF RESULTS END  **************");
            Console.WriteLine();

            // Ternary operator - used to assign a value to a variable based on a condition.
            Console.WriteLine("***************  Ternary operator Results  *****************");

            string passStatus = grade < 50 ? "Fail" : "Pass";
            Console.WriteLine($"Student Status is : {passStatus}");

            Console.WriteLine("***************  Ternary operator Results End  *****************");


            Console.WriteLine();

            Console.WriteLine("***************  SWITCH STATEMENTS RESULTS  *****************");
            /*SWITCH STATEMENTS
             * Write a program to accept an integer as the day of the week and print the appropriate message as outlined below
             * 1 - Sunday
             * 2 - Monday
             * 3 - Tuesday
             * 4 - Wednesday (Hump Day!)
             * 5 - Thursday
             * 6 - Friday (TGIF)
             * 7 - Saturday
             * */
            int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
            


            switch(dayOfTheWeek)
            {
                case 1: 
                    Console.WriteLine("Sunday");
                    break;
                    case 2: 
                    Console.WriteLine("Monday");
                    break;
                    case 3: 
                    Console.WriteLine("Tuesday");
                    break;
                    case 4: 
                    Console.WriteLine("Wednesday");
                    break;
                    case 5: 
                    Console.WriteLine("Thursday");
                    break;
                    case 6: 
                    Console.WriteLine("Friday");
                    break;
                    case 7: 
                    Console.WriteLine("Saturday");
                    break;
                    default: 
                    Console.WriteLine("Invalid Input");
                    break;
            }


            Console.WriteLine("***************  SWITCH STATEMENTS RESULTS END  *****************");
            //The rest of the application
            Console.WriteLine("Thank you for using the program");
            Console.ReadKey();
        }
    }
}
