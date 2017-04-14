using System;

namespace Test
{
    public class Program
    {
        public static void Main()
        {
            Person person;
            person.FirstName = "Yugander";
            person.LastName = "Annamaneni";
            person.Age = 100;

            Console.Write(person.FirstName + "\n");
            Console.Write(person.LastName + "\n");
            Console.Write(person.Age + "\n");

            Object obj = person;//boxing value type to reference type.
            person = (Person)obj;//unboxing object type to value type(struct).

            Console.Write(person.FirstName + "\n");

            Console.ReadLine();
        }
    }

    public struct Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
    }
}
