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
            









        }
    }
}
