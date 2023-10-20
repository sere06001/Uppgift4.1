using System;
namespace Uppgift4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i < 31; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 200; i > 179; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 1000; i < 1401; i += 50)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}