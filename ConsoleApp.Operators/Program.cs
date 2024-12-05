namespace ConsoleApp.Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompt user for inputs
            Console.WriteLine("Please enter the first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());

            // Add numbers
            int sum = firstNumber + SecondNumber;
            // multiply
            int product = firstNumber * SecondNumber;
            // Divide
            int qoutient = firstNumber / SecondNumber;
            // Subtract
            int difference = firstNumber - SecondNumber;
            // Modulus
            int mod = firstNumber % SecondNumber;
            Console.WriteLine("********** MATH RESULTS********************");
            Console.WriteLine();
            Console.WriteLine($"Sum : {sum}");
            Console.WriteLine($"Sum : {difference}");
            Console.WriteLine($"Sum : {product}");
            Console.WriteLine($"Sum : {qoutient}");
            Console.WriteLine($"Sum : {mod}");
            Console.WriteLine();
            Console.WriteLine("*************END MATH RESULTS**************");
            Console.WriteLine();

            /* 
                Logic Operations and Operators 
             */

            bool isGreaterThan = firstNumber > SecondNumber;
            bool isLessThan = firstNumber < SecondNumber;
            bool isEqualTo = firstNumber == SecondNumber;
            bool isGreaterThanOrEqualTo = firstNumber >= SecondNumber;
            bool isLessThanOrEqualTo = firstNumber <= SecondNumber;
            bool isNotEqual = firstNumber != SecondNumber;

            Console.WriteLine("********************* LOGIC RESULTS********************");
            Console.WriteLine();
            Console.WriteLine($"Is Greater Than: {isGreaterThan}");
            Console.WriteLine($"Is Less Than: {isLessThan}");
            Console.WriteLine($"Is Equal To: {isEqualTo}");
            Console.WriteLine($"Is Greater Than or Equal To: {isLessThanOrEqualTo}");
            Console.WriteLine($"Is Less Than or Equal To: {isLessThanOrEqualTo}");
            Console.WriteLine($"Is Not Equal: {isNotEqual}");
            Console.WriteLine();
            Console.WriteLine("*********************END LOGIC RESULTS********************");
            Console.WriteLine();

            /* 
                Assignment Operations and Operators 
             */

            Console.WriteLine("Enter Random Value for Assignment Operations");
            int randomValue = Convert.ToInt32( Console.ReadLine());
            // int increaseValue = firstNumber + randomValue;


            Console.WriteLine("********************* ASSIGNMENT RESULTS********************");
            Console.WriteLine();
            firstNumber += randomValue;
            Console.WriteLine($"First Number increased by {randomValue} : {firstNumber}");
            firstNumber -= randomValue;
            Console.WriteLine($"First Number reduced by {randomValue} : {firstNumber}");
            firstNumber /= randomValue;
            Console.WriteLine($"First Number divided by {randomValue} : {firstNumber}");
            firstNumber *= randomValue;
            Console.WriteLine($"First Number multiplied by {randomValue} : {firstNumber}");    
            firstNumber %= randomValue;
            Console.WriteLine($"First Number mod by {randomValue} : {firstNumber}");
            Console.WriteLine("*********************END ASSIGNMENT RESULTS********************");
            Console.WriteLine();


            Console.ReadKey();


        }
    }
}
