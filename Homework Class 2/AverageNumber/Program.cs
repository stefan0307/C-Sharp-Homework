namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            bool check = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter second number");
            bool check1 = int.TryParse(Console.ReadLine(), out int secondNumber);
            Console.WriteLine("Enter first number");
            bool check2 = int.TryParse(Console.ReadLine(), out int thirdNumber);
            Console.WriteLine("Enter second number");
            bool check3 = int.TryParse(Console.ReadLine(), out int fourthNumber);
            int result = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
            if (!check || !check1 || !check2 || !check3) 
            {
             Console.WriteLine("Enter a valid input!");
            }
            else
            {
                Console.WriteLine("The average of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + " & " + fourthNumber + " is " + result);
            }
        }
    }
}