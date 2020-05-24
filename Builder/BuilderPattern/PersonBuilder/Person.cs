using System;
namespace DesignPatterns.BuilderPattern.PersonBuilder
{
    public class Person
    {
        //endereco
        public string StreetAddress, Postcode, City;

        //trabalho
        public string CompanyName, Position;
        public int AnnualIncome;

        public override string ToString()
        {
            return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(Postcode)}: {Postcode}, {nameof(City)}: {City}, {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
        }
    }
}
