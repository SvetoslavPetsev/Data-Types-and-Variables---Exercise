using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inputNumber = int.Parse(input);
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int a = inputNumber % 10;
                sum += a;
                inputNumber /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
