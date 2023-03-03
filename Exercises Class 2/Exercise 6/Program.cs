namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the first number");
            int inputOne;
            int.TryParse(Console.ReadLine(), out inputOne);
            Console.WriteLine("Type the first number");
            int inputTwo;
            int.TryParse(Console.ReadLine(), out inputTwo);

            if (inputOne > inputTwo)
            {
                Console.WriteLine(inputOne + " is larger than " + inputTwo);
            }
            else
            {
                Console.WriteLine(inputTwo + " is larger than " + inputOne);
            }

            if (inputOne % 2 == 0)
            {
                Console.WriteLine(inputOne + " is even");
            }
            else
            {
                Console.WriteLine(inputOne + " is odd");
            }

            if (inputTwo % 2 == 0)
            {
                Console.WriteLine(inputTwo + " is even");
            }
            else
            {
                Console.WriteLine(inputTwo + " is odd");
            }
        }
    }
}