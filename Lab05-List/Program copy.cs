using System.Collections;
using System.Globalization;

namespace Lab05_List;
class Programlista
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public CountryEnum Country { get; set; }
    }

    public enum CountryEnum
    {
        PL,
        UK,
        EC,
        DE
    }

    static void Main4(string[] args)

    {
        List<Person> people = new List<Person>();
        people.Add(new Person() { Name = "Marcin", Country = CountryEnum.PL, Age = 29 });
        people.Add(new Person() { Name = "Sabine", Country = CountryEnum.DE, Age = 25 });
        people.Add(new Person() { Name = "Ann", Country = CountryEnum.PL, Age = 31 });
        people.Add(new Person() { Name = "Frank", Country = CountryEnum.EC, Age = 24 });
        List<Person> results = people.OrderBy(p => p.Name).ToList();
        foreach (Person person in results)
        {
            Console.WriteLine($"{person.Name} ({person.Age} years) from {person.Country}.");
        }

        List<string> names = people.Where(p => p.Age <= 30).OrderBy(p => p.Name).Select(p => p.Name).ToList();
        foreach (String name in names)
        {
            Console.WriteLine($"{name} ");
        }
        List<string> namess = (from p in people where p.Age <= 35 orderby p.Age select p.Name).ToList();
        foreach (String name in namess)
        {
            Console.WriteLine($"{name} ");
        }


    }

}
