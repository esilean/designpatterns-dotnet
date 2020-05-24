using System;
using DesignPatterns.FactoryPattern.PersonFactory;
using DesignPatterns.FactoryPattern.PointFactory;
using static System.Console;

namespace Factory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // factory pattern
            var cp = Point.Factory.NewCartesianPoint(1, 2);
            WriteLine($"Cartesian Point: {cp}");
            var pp = Point.Factory.NewPolarPoint(1, 2);
            WriteLine($"Polar Point: {pp}");

            var pf = new PersonFactory();
            var p1 = pf.CreatePerson("Jonh Doe");
            WriteLine(p1.Id);
            var p2 = pf.CreatePerson("Jow Jane");
            WriteLine(p2.Id);
        }
    }
}
