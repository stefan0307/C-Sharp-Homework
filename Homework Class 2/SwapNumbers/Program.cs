namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter second number number:");
            int.TryParse(Console.ReadLine(), out int num2);
            int swapNumbers = num1;
            num1 = num2;
            num2 = swapNumbers;
            Console.WriteLine("After Swap:");
            Console.WriteLine("First number is now " + num1);
            Console.WriteLine("Second number is now " + num2);
        }
    }
}