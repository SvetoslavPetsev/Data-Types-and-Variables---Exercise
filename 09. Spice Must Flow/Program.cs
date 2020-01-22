using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountSpice = int.Parse(Console.ReadLine());
            int daycounter = 0;
            int totalHurvest = 0;
            if (amountSpice < 100)
            {
                Console.WriteLine(daycounter);
                Console.WriteLine(totalHurvest);
                return;
            }
            while (amountSpice >= 100)
            {
                int dayHurvest = 0;
                dayHurvest = amountSpice - 26;
                totalHurvest += dayHurvest;
                amountSpice -= 10;
                daycounter++;
            }
            totalHurvest -= 26;
            Console.WriteLine(daycounter);
            Console.WriteLine(totalHurvest);
        }
    }
}
