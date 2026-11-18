using LibraryAccounting.Entities;
using System;
using System.Collections.Generic;

namespace LibraryAccounting.Repositories.Implementations
{
    internal class ReaderRepository : IReaderRepository
    {
        public void CreateReader(Reader reader)
        {
        }

        public void DeleteReader(int id)
        {
        }

        public Reader ReadReaderById(int id)
        {
            // Заглушка: возвращаем пустого читателя
            return Reader.CreateEntity(0, string.Empty, string.Empty, DateTime.Now);
        }

        public IEnumerable<Reader> ReadReaders()
        {
            // Заглушка: возвращаем пустой список
            return new List<Reader>();
        }

        public void UpdateReader(Reader reader)
        {
        }
    }
}