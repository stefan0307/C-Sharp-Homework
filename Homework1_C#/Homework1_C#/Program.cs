namespace Homework1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Without command for new line
            Console.WriteLine("    *");
            Console.WriteLine("   ***");
            Console.WriteLine("  *****");
            Console.WriteLine(" *******");
            Console.WriteLine("*********");
            
            //With command for new line (\r\n is for Windows, \r is for Mac and \n is for Unix)
            Console.WriteLine("    *\r\n   ***\r\n  *****\r\n *******\r\n*********");
        }
    }
}