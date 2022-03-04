using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = n; i < m; i++)
            {
                if (i % 7 == 0 && i!=0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
