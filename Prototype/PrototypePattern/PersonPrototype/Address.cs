using System;
namespace Prototype.PrototypePattern.PersonPrototype
{
    public class Address
    {
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }

        public Address()
        {

        }
        public Address(string streetName, int houseNumber)
        {
            StreetName = streetName ?? throw new ArgumentNullException(paramName: nameof(streetName));
            HouseNumber = houseNumber;
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)} {HouseNumber}";
        }

    }
}
