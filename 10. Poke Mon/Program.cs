using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int counterTarget = 0;
            int exPower = pokePowerN / 2;
            while (true)
            {
                if (pokePowerN < distanceM)
                {
                    break;
                }
                pokePowerN -= distanceM;
                counterTarget++;
                if (pokePowerN == exPower)
                {
                    if (exhaustionFactorY > 0)
                    {
                        pokePowerN /= exhaustionFactorY;
                    }
                }
            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(counterTarget);
        }
    }
}
