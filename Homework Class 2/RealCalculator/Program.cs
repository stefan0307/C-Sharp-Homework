using System.Diagnostics;
using System.Linq.Expressions;

namespace Homework_Class_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            bool check = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter second number");
            bool check1 = int.TryParse(Console.ReadLine(), out int secondNumber);
            if (!check || !check1)
            {
                Console.WriteLine("Please enter a valid input!");
            }else
            {
                Console.WriteLine("What operation do you want to do out of the following (+, -, * or /):");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Console.WriteLine("The result is: " + (firstNumber + secondNumber));
                        break;
                    case "-":
                        Console.WriteLine("The result is: " + (firstNumber - secondNumber));
                        break;
                    case "*":
                        Console.WriteLine("The result is: " + (firstNumber * secondNumber));
                        break;
                    case "/":
                        Console.WriteLine("The result is: " + (firstNumber / secondNumber));
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
            }
        }
    }
}