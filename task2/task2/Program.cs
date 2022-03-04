using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Ay;
            Console.WriteLine("Ay yazin");
            Ay = Console.ReadLine();
            switch (Ay)
            {
                case "Fevral":
                    Console.WriteLine(28);
                    break;
                case "Aprel":
                case "Iyun":
                case "Sentyabr":
                case "Noyabr":
                    Console.WriteLine(30);
                    break;
                case "Yanvar":
                case "Mart":
                case "May":
                case "Iyul":
                case "Avqust":
                case "Oktyabr":
                case "Dekabr":
                    Console.WriteLine(31);
                    break;
                default:
                    Console.WriteLine("bele gun yoxdu");
                    break;
            }
        }
    }
}
