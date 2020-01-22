using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int person = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courseCounter = 0;

            while (true)
            {
                int newCourse = person - capacity;
                courseCounter++;
                person -= capacity;
                if (newCourse <= 0)
                {
                    break;
                }
            }
            Console.WriteLine(courseCounter);
        }
    }
}
