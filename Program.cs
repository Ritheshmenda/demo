using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number a:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number b:");
            int y = Convert.ToInt32(Console.ReadLine());
            int sum =x + y;
            Console.WriteLine("sum is:" + sum);

        }
    }
}
