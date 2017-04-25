
using FamilyTreeStructure.Model;

namespace FamilyTreeStructure.Interfaces
{
    /// <summary>
    /// The FamilyTree interface.
    /// </summary>
    public interface IFamilyTree
    {
        /// <summary>
        /// The show tree.
        /// </summary>
        void ShowTree(Person person);

        /// <summary>
        /// The search by name.
        /// </summary>
        /// <param name="searchText">
        /// The search text.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        string SearchByName(string searchText);
    }
}
