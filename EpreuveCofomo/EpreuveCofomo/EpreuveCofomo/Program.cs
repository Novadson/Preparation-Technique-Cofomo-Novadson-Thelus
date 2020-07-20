using System;
using System.Linq;
public class Program
{
    static void Main(string[] args)
    {
        Person[] persons = { new Person { Name = "Mike", Age = 25 }, new Person { Name = "Joe", Age = 43 }, new Person { Name = "Nadia", Age = 31 } };

        var result = persons.Where(p => p.Age >= 30); //USING WHERE

        Console.WriteLine("Finding persons who are 30 years old or older:");
        foreach (Person person in result)
            Console.WriteLine(String.Format("{0}: {1} years old", person.Name, person.Age));

        Console.WriteLine("*****************************************");

        foreach (Person person in persons)
        {
            if (person.Name == "Mike" && person.Age.Equals(25))
                Console.WriteLine(String.Format("{0}: {1} years old", person.Name, person.Age));
            continue;//USING WHERE
        }

    }
}
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}