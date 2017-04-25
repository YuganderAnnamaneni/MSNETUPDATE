using FamilyTreeStructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeStructure
{
    using FamilyTreeStructure.Model;

    public class FamilyTree : IFamilyTree
    {
        private static FamilyTree _familyTree = null;

        public Person Person { get; set; }

        public DateTime CrateadOn { get; set; }

        private FamilyTree()
        {
            CrateadOn = DateTime.Now;
            Person = new Person();
        }

        public static FamilyTree Create()
        {
            return _familyTree ?? (_familyTree = new FamilyTree());
        }

        public List<Person> SearchByName(string searchText)
        {
            List<Person> persons = new List<Person>();
        }

        public void ShowTree(Person person)
        {
            if (person.Father != null && person.Mother != null)
            {
                ShowParent(person.Father);
                ShowParent(person.Mother);
            }

            if (person.Childs.Count > 0)
            {
                Console.Write(" \\-");
                Console.WriteLine(person.ToString());

                for (int i = 0; i < person.Childs.Count; i++)
                {
                    ShowTree(person.Childs[i]);
                }
            }
            else
            {
                Console.Write("   \\-");
                Console.WriteLine(person.ToString());
            }
        }

        private void ShowParent(Person person)
        {
            Console.Write("|-");
            Console.WriteLine(person.ToString());
        }
    }
}
