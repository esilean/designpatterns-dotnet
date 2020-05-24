using System;
using DesignPatterns.BuilderPattern.CodeBuilder;
using DesignPatterns.BuilderPattern.PersonBuilder;
using static System.Console;

namespace Builder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // builder pattern
            var cb = new CodeBuilder("Person")
                .AddField("string", "Name")
                .AddField("int", "Age");
            WriteLine(cb);

            var pb = new PersonBuilder();
            Person person = pb
                    .Lives
                      .At("123 London Road")
                      .In("London")
                      .WithPostcode("SW12BC")
                    .Works
                      .At("Fabrikam")
                      .AsA("Engineer")
                      .Earning(123000);
            WriteLine(person);
        }
    }
}
