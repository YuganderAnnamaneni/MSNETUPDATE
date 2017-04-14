using System;

namespace IEquatable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Object person3 = new Person();

            //This method calls IEquatable interface Equals method as both are of same type.
            bool retval = person1.Equals(person2);

            Console.WriteLine("Both objects are equal: " + retval);

            //This method calls Overrided Equals method as both are of different type.
            retval = person1.Equals(person3);

            Console.ReadLine();
        }
    }

    public class Person : IEquatable<Person>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Implementing IEquatable interface with Person class, To check equality between to objects of same type.
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public bool Equals(Person person)
        {
            return (person.Id == this.Id && person.Name == this.Name);
        }

        /// <summary>
        /// Overriding Equals method of System.Object class to check equality between objects by casting object to specific type.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Person person = (Person)obj;
            return (person.Id == this.Id && person.Name == this.Name);
        }
    }
}
