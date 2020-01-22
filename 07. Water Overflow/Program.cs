using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numberInput; i++)
            {
                int newlitters = int.Parse(Console.ReadLine());
                if (sum + newlitters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                sum += newlitters;
            }
            Console.WriteLine(sum);
        }
    }
}
