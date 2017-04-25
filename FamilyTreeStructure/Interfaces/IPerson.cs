
namespace FamilyTreeStructure.Interfaces
{
    using Model;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The Person interface.
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// The add parent.
        /// </summary>
        void AddParent(Person person);

        /// <summary>
        /// The add child.
        /// </summary>
        void AddChild(Person child);

        /// <summary>
        /// The add childs.
        /// </summary>
        void AddChilds(List<Person> childs);
    }
}
