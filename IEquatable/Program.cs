using System;

namespace IEquatable
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company1 = new Company() { Name = "EPAM", Address = "EPAM Systems, Hyderabad", NoOfEmployees = 1000 };
            Company company2 = new Company() { Name = "EPAM", Address = "EPAM Systems, Pune", NoOfEmployees = 1000 };

            //This method calls IEquatable interface Equals method as both are of same type.
            bool retval = company1.Equals(company2);

            Console.WriteLine("Both objects are equal: " + retval);

            Console.ReadLine();
        }
    }

    public class Company : IEquatable<Company>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int NoOfEmployees { get; set; }

        /// <summary>
        /// Implementing IEquatable interface with Person class, To check equality between to objects of same type.
        /// </summary>
        /// <param name="company">Company</param>
        /// <returns>bool</returns>
        public bool Equals(Company company)
        {
            return company.Name == this.Name;
        }

        /// <summary>
        /// Overriding Equals method of System.Object class to check equality between objects by casting object to specific type.
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>bool</returns>
        public override bool Equals(object obj)
        {
            Company company = obj as Company;
            return company.Name == this.Name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
