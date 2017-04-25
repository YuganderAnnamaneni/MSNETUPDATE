using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeStructure.Model
{
    using FamilyTreeStructure.Interfaces;
    using System.Globalization;

    public class Person : IPerson
    {
        public Person()
        {
            this.Childs = new List<Person>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Nullable<DateTime> DateOfDeath { get; set; }

        public Gender Gender { get; set; }

        public Person Father { get; set; }

        public Person Mother { get; set; }

        public List<Person> Childs { get; set; }

        public void AddParent(Person person)
        {
            if (person.Gender == Gender.Male)
            {
                this.Father = person;
            }
            else if (person.Gender == Gender.Female)
            {
                this.Mother = person;
            }
        }

        public void AddChild(Person child)
        {
            this.Childs.Add(child);
        }

        public void AddChilds(List<Person> childs)
        {
            this.Childs.AddRange(childs);
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} [Date of birth]({2}) - [Date of death]({3})", this.FirstName, this.LastName, this.DateOfBirth, this.DateOfDeath != null ? this.DateOfDeath.ToString() : "NA");
        }
    }
}
