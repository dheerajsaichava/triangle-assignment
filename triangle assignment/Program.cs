using System;

namespace triangle_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows :");
            int i = int.Parse(Console.ReadLine());
            for (int x = i; x >= 1; x--)
            {
                for (int y = i; y > x; y--)
                {
                    Console.Write("  ");
                }
                for (int z= 1; z < 2 * x; z++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
