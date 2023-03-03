namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of trees:");
            int userInputTrees;
            int.TryParse(Console.ReadLine(), out userInputTrees);
            int branchesOnTree = 12;
            int applesOnTree = 8;
            int basketWithApples = 5;
            int totalNumberOfApples = applesOnTree * branchesOnTree * userInputTrees;
            Console.WriteLine("You need " + totalNumberOfApples / basketWithApples + " baskets to collect all the apples from the trees");
        }
    }
}