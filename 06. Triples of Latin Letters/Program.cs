using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLetters = int.Parse(Console.ReadLine());
            int endSimmbol = 97 + (numberLetters - 1);
            for (int i = 97; i <= endSimmbol; i++)
            {
                for (int j = 97; j <= endSimmbol; j++)
                {
                    for (int k = 97; k <= endSimmbol; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
