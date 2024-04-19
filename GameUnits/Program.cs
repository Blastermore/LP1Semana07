using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit MilitaryUnit mu = new MilitaryUnit(5,10,10);
            Unit SettlerUnit su = new SettlerUnit(10,5);

            mu.Move();
            su.Move();

            Console.WriteLine($"{mu.Health} {mu.Cost}");
            Console.WriteLine($"{su.Health} {su.Cost}");

        }
    }
}
