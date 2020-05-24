using System;
namespace DesignPatterns.BuilderPattern.PersonBuilder
{
    public class PersonBuilder
    {
        // o objeto que será contruído como referencia
        protected Person person = new Person();

        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);
        public PersonJobBuilder Works => new PersonJobBuilder(person);

        //obter o objeto pessoa, nao o objeto "Person...Builder"
        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.person;
        }
    }
}
