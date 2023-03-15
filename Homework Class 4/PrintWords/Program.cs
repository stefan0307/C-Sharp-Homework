string userInput = "";

while (userInput != "quit")
{
    
    Console.WriteLine("Type a sentence:");
    userInput = Console.ReadLine();

    string[] inputSplit = userInput.Split(' ');
    for (int i = 0; i < inputSplit.Length; i++)
    {
            Console.WriteLine(inputSplit[i]);
    }
    
}