using LibraryAccounting.Entities;
using System.Collections.Generic;

namespace LibraryAccounting.Repositories
{
    public interface ILibrarianRepository
    {
        IEnumerable<Librarian> ReadLibrarians();
        Librarian ReadLibrarianById(int id);
        void CreateLibrarian(Librarian librarian);
        void UpdateLibrarian(Librarian librarian);
        void DeleteLibrarian(int id);
    }
}