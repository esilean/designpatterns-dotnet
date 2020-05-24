using Prototype.PrototypePattern;
using Prototype.PrototypePattern.LinePrototype;
using Prototype.PrototypePattern.PersonPrototype;
using static System.Console;
namespace Prototype
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            var lebevila = new Person(new[] { "Le", "Bevilaqua" }, new Address("Diana Street", 1001));

            var refag = lebevila.DeepCopyXml();
            refag.Names[0] = "Re";
            refag.Address.HouseNumber = 200;

            WriteLine(lebevila);
            WriteLine(refag);

            var l = new Line
            {
                Start = new Point { X = 1, Y = 2 },
                End = new Point { X = 2, Y = 3 }
            };
            WriteLine(l);

            var lcopy = l.DeepCopy();
            lcopy.Start = new Point { X = 55, Y = 11 };
            WriteLine(lcopy);

        }
    }
}
