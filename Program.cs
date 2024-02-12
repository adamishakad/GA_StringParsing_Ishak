namespace GA_StringParsing_Ishak
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string string12 = "12"; 
            int number12 = int.Parse(string12); 
            int addValue = number12 + number12; 
            Console.WriteLine(addValue);

            Console.Write("Enter your first number: "); 
            string userNum1 = Console.ReadLine(); 
            Console.Write("Enter your second number: ");
            string userNum2 = Console.ReadLine();

            int number1 = int.Parse(userNum1);
            int number2 = int.Parse(userNum2);

            int sum = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {sum}");

            string myString = "42";

            try
            {
                int myNumber = int.Parse(myString);
                Console.WriteLine($"Your number was an Integral: {myNumber}");
            }
            catch
            {
                Console.WriteLine("You had an error");

            }
            // This is how parse the users numbers

            // Part 1 : Asking the user for the values
            // Number 1
            Console.Write("Enter your first number: ");
            string stringNumber1 = Console.ReadLine();
            // Number 2
            Console.Write("Enter your second number: ");
            string stringNumber2 = Console.ReadLine();
            // Number 3
            Console.Write("Enter your third number: ");
            string stringNumber3 = Console.ReadLine();


            try
            { // try open curly brace
              // Part 2 : Parsing the users values
                double userNumber1 = double.Parse(stringNumber1);
                double userNumber2 = double.Parse(stringNumber2);
                double userNumber3 = double.Parse(stringNumber3);

                // Part 3 : Performing our math
                double sumAllNumbers = userNumber1 + userNumber2 + userNumber3; // Adding our 3 numbers
                double average = sumAllNumbers / 3; // Dividing the sum by the number of elements

                // Part 4 : Displaying our result
                Console.WriteLine($"The average of your 3 numbers is {average}");

            } // Closing Curly brace
            catch
            { // catch opening curly brace

                // This will run if our an error is thrown
                Console.WriteLine("You had an error");
            } // closing curly brace












        } // Main

    } // Class

} // nanespace
