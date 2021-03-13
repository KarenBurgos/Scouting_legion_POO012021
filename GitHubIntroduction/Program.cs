using System;

namespace GitHubIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a value for a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.Write("Enter a value for b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"multiplication {a} * {b} equals {AddNumbers(a, b)}");
        }

        public static int AddNumbers(int a, int b)
        {
            return a * b;
        }
    }
}
