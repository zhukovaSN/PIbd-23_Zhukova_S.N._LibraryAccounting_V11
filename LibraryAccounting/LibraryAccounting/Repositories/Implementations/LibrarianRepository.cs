using LibraryAccounting.Entities;
using LibraryAccounting.Entities.Enums;
using System.Collections.Generic;

namespace LibraryAccounting.Repositories.Implementations
{
    internal class LibrarianRepository : ILibrarianRepository 
    {
        public void CreateLibrarian(Librarian librarian)
        {
        }

        public void DeleteLibrarian(int id)
        {
        }

        public Librarian ReadLibrarianById(int id)
        {
            return Librarian.CreateEntity(0, string.Empty, string.Empty, LiteraryTheme.None);
        }

        public IEnumerable<Librarian> ReadLibrarians()
        {
            return new List<Librarian>();
        }

        public void UpdateLibrarian(Librarian librarian)
        {
        }
    }
}