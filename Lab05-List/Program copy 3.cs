using System.Collections;
using System.Globalization;

namespace Lab05_List;
class Programlista4
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

    static void Main77(string[] args)

    {
        SortedList<string, Person> people = new SortedList<string, Person>();

        //List<Person> people = new List<Person>();
        people.Add("Marcin", new Person() { Name = "Marcin",Country = CountryEnum.PL, Age = 29 });
        people.Add("Sabine", new Person() { Name = "Sabine", Country = CountryEnum.DE, Age = 25 });
        people.Add("Ann", new Person() { Name = "Ann", Country = CountryEnum.PL, Age = 31 });

        foreach (KeyValuePair<string, Person> person in people)
        {
            Console.WriteLine($"{person.Value.Name} ({person.Value.Age} years) from {person.Value.Country}.");
        }

    }

}
