namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 1000;
            Console.WriteLine("1) Check Balance");
            Console.WriteLine("2) Withdraw Money");

            bool checkUserInput = int.TryParse(Console.ReadLine(), out int optionOneORTwo);
            if (!checkUserInput)
            {
                Console.WriteLine("Invalid Input!");
            }
            else
            {
                switch (optionOneORTwo)
                {
                    case 1:
                        Console.WriteLine("You have " + balance + "$ on your account");
                        break;
                    case 2:
                        Console.WriteLine("How much money do you want to withdraw?");
                        bool moneyWithdraw = int.TryParse(Console.ReadLine(), out int newBalance);
                        if (moneyWithdraw && newBalance > 0 && newBalance <= balance)
                        {
                            balance -= newBalance;
                            Console.WriteLine("You now have " + balance + "$ on your account and have successfully withdrawn " + newBalance + "$");
                        }
                        else if (moneyWithdraw && newBalance > balance)
                        {
                            Console.WriteLine("You can't withdraw that amount because your balance is: " + balance + "$");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input!");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            }
        }
    }
}