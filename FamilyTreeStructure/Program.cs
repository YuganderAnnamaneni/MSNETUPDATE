using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeStructure
{
    using FamilyTreeStructure.Interfaces;
    using FamilyTreeStructure.Model;

    class Program
    {
        static void Main(string[] args)
        {
            FamilyTree tree = FamilyTree.Create();
            tree = GetFamilyTree(tree);

            tree.ShowTree(tree.Person);
            Console.ReadLine();
        }

        static FamilyTree GetFamilyTree(FamilyTree tree)
        {
            tree.Person = new Person()
            {
                FirstName = "Yugander",
                LastName = "Annamaneni",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(1989, 01, 24),
            };

            tree.Person.AddParent(new Person()
            {
                FirstName = "Ashok",
                LastName = "Annamaneni",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(1969, 01, 24),
            });

            tree.Person.AddParent(new Person()
            {
                FirstName = "Luxmi",
                LastName = "Annamaneni",
                Gender = Gender.Female,
                DateOfBirth = new DateTime(1972, 01, 24),
            });

            tree.Person.AddChild(new Person()
            {
                FirstName = "Suhash",
                LastName = "Annamaneni",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(2015, 01, 24),
            });

            return tree;
        }
    }
}
