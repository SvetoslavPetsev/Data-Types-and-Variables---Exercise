using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInputs = int.Parse(Console.ReadLine());
            double biggestVolume = double.MinValue;
            string biggestKeg = "";

            for (int i = 1; i <= numberInputs; i++)
            {
                string modelKeg = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                double volume = Math.PI * r * r * h;
                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = modelKeg;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
