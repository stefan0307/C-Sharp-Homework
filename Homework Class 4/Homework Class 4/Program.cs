string userInput = "";

while (userInput != "quit")
{
    Console.WriteLine("Type something:");
    userInput = Console.ReadLine();

    if (userInput.Length >= 5 && userInput != "quit")
    {
        string lastCharacters = userInput.Substring(userInput.Length - 5);
        Console.WriteLine("The last 5 characters are:");
        Console.WriteLine(lastCharacters);
    }
    else if (userInput != "quit")
    {
        Console.WriteLine("The string is to short, please try again:");
    }
}