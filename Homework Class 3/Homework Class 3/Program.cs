namespace Homework_Class_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] SumOfEven = new int[6];
            for (int i = 0; i<SumOfEven.Length; i++)
            {
                Console.WriteLine("Enter integer number " + (i + 1));
                bool test = int.TryParse(Console.ReadLine(), out SumOfEven[i]);
                while (!test) { 
                    if (!test)
                    {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("Enter integer number " + (i + 1));
                    test = int.TryParse(Console.ReadLine(), out SumOfEven[i]);
                    }
                }
            }

            int result = 0;
            for (int i = 0;  i < SumOfEven.Length; i++)
            {
                if (SumOfEven[i] % 2 == 0)
                {
                    result += SumOfEven[i];
                }
            }
            Console.WriteLine("The result is: " + result);
        }
    }
}