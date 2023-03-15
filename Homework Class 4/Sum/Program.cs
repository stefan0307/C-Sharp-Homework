Console.Write("Enter the Number : ");
int number = int.Parse(Console.ReadLine());

int SumOfDigits (int input)
{
    int sum = 0, reminder;

    while (input > 0)
    {
        reminder = input % 10;
        sum = sum + reminder;
        input = input / 10;
    }

    return sum;
}

Console.WriteLine("The sum of all digits is: " + SumOfDigits(number));
