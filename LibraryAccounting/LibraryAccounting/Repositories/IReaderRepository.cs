using LibraryAccounting.Entities;
using System.Collections.Generic;

namespace LibraryAccounting.Repositories
{
    public interface IReaderRepository
    {
        IEnumerable<Reader> ReadReaders();
        Reader ReadReaderById(int id);
        void CreateReader(Reader reader);
        void UpdateReader(Reader reader);
        void DeleteReader(int id);
    }
}