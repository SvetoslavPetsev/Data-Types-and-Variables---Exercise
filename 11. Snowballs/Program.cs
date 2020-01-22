using System;
using System.Numerics;
namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballNumber = int.Parse(Console.ReadLine());
            BigInteger highestValue = 0;
            int ss = 0;
            int st = 0;
            int sq = 0;
            BigInteger newValue;

            for (int i = 0; i < snowballNumber; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
               
                newValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (newValue > highestValue)
                {
                    highestValue = newValue;
                    ss = snowballSnow;
                    st = snowballTime;
                    sq = snowballQuality;
                }
            }
            Console.WriteLine($"{ss} : {st} = {highestValue} ({sq})");
        }
    }
}
