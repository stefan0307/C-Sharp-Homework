Console.WriteLine("When were you born? (Month/Day/Year)");
bool userInput = DateTime.TryParse(Console.ReadLine(), out DateTime birthday);

if (!userInput)
{
    Console.WriteLine("Invalid Input");
}
else
{
    int age = AgeCalculator(birthday);
    Console.WriteLine("You are currently " + age + " years old!");
}

int AgeCalculator(DateTime birthdate)
{
    int age = DateTime.Now.Year - birthdate.Year;
    if (DateTime.Now.DayOfYear < birthdate.DayOfYear && birthdate.Year <= DateTime.Now.Year)
    {
        age--;
    }
    else
    {
        Console.WriteLine("Invalid Input");
        
    }
    return age;
}