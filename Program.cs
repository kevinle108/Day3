using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {

            printMultTable();
            printMultTableWhileLoop();
            printMultTableForWhileLoop();
            printMultTableWhileForLoop();





            void printMultTable()
            {
                Console.WriteLine("Multiplication Table using For Loop");
                for (int i = 1; i <= 12; i++)
                {
                    for (int j = 1; j <= 12; j++)
                    {
                        Console.WriteLine($"{i} x {j} = {i*j}");
                    }
                    Console.WriteLine();
                }
            }

            void printMultTableWhileLoop()
            {
                Console.WriteLine("Multiplication Table using While Loop");
                int i = 1;
                while (i <= 12)
                {
                    int j = 1;
                    while (j <= 12)
                    {
                        Console.WriteLine($"{i} x {j} = {i * j}");
                        j++;
                    }
                    Console.WriteLine();
                    i++;
                }                
            }

            void printMultTableForWhileLoop()
            {
                Console.WriteLine("Multiplication Table using For and While Loop");
                for (int i = 1; i <= 12; i++)
                {
                    int j = 1;
                    while (j <= 12)
                    {
                        Console.WriteLine($"{i} x {j} = {i * j}");
                        j++;
                    }
                    Console.WriteLine();
                }
            }

            void printMultTableWhileForLoop()
            {
                Console.WriteLine("Multiplication Table using While and For Loop");
                int i = 1;
                while (i <= 12)
                {
                    for (int j = 1; j <= 12; j++)
                    {
                        Console.WriteLine($"{i} x {j} = {i * j}");
                    }
                    Console.WriteLine();
                    i++;
                }
            }
        }
    }
}
