using System;

namespace Prototype.PrototypePattern.PersonPrototype
{
    public class Person
    {
        public string[] Names { get; set; }
        public Address Address { get; set; }

        public Person()
        {

        }
        public Person(string[] names, Address address)
        {
            Names = names ?? throw new ArgumentNullException(paramName: nameof(names));
            Address = address ?? throw new ArgumentNullException(paramName: nameof(address));
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ", Names)}, {nameof(Address)} {Address}";
        }

    }
}
