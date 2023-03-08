namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to see students in G1. Press 2 to see students in G2:");

            string[] studentsG1 = new string[] {"Stefan", "Filip", "Boshko", "Angela", "Bojana"};
            string[] studentsG2 = new string[] { "Ivana", "Gorazd", "Ljupco", "Matea", "Mihaela" };

            bool userInput = int.TryParse(Console.ReadLine(), out int classNumber);
            if (!userInput || classNumber < 1 || classNumber > 2)
            {
                Console.WriteLine("Invalid Input!");

            }else
            {
                if (classNumber == 1)
                {
                    Console.WriteLine("The Students in G1 are:");
                    for (int i = 0; i < studentsG1.Length; i++)
                    {
                        Console.WriteLine(studentsG1[i]);
                    }
                }
                else if (classNumber == 2)
                {
                    Console.WriteLine("The Students in G1 are:");
                    for (int i = 0; i < studentsG2.Length; i++)
                    {
                        Console.WriteLine(studentsG2[i]);
                    }
                }
            }
            

            //string userInput = Console.ReadLine();
            //switch (userInput)
            //{
            //    case "1":
            //        Console.WriteLine("The Students in G1 are:");
            //        for (int i = 0; i < studentsG1.Length; i++)
            //        {
            //            Console.WriteLine(studentsG1[i]);
            //        }
            //        break;
            //    case "2":
            //        Console.WriteLine("The Students in G1 are:");
            //        for (int i = 0; i < studentsG2.Length; i++)
            //        {
            //            Console.WriteLine(studentsG2[i]);
            //        }
            //        break;
            //    default: 
            //        Console.WriteLine("Invalid Input!");
            //        break;
            //}
        }
    }
}