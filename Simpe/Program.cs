using Simpe.Profile;
using Simple.Entity;

namespace Simpe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dto = new PersonDto { Name = "Ahmed", Age = 25 };

            var person = SimpleMapper.Map<PersonDto, Person>(dto);

            Console.WriteLine($"Name {person.Name} : \n  age {person.Age}");
        }
    }
}
