using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit  mu = new MilitaryUnit(5,10,10);
            Unit  su = new SettlerUnit();

            mu.Move();
            su.Move();

            Console.WriteLine($"{mu.Health} {mu.Cost}");
            Console.WriteLine($"{su.Health} {su.Cost}");

        }
    }
}
