using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInputs = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numberInputs; i++)
            {
                char simbol = char.Parse(Console.ReadLine());
                sum += simbol;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
