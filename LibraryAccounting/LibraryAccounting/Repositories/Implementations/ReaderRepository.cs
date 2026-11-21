using LibraryAccounting.Data;
using LibraryAccounting.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace LibraryAccounting.Repositories.Implementations
{
    internal class ReaderRepository : IReaderRepository
    {
        private readonly LibraryContext _context;
        private readonly ILogger<ReaderRepository> _logger;

        public ReaderRepository(LibraryContext context, ILogger<ReaderRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void CreateReader(Reader reader)
        {
            _logger.LogInformation("Добавление читателя: {FullName}", reader.FullName);
            _context.Readers.Add(reader);
            _context.SaveChanges();
        }

        public void UpdateReader(Reader reader)
        {
            _logger.LogInformation("Обновление читателя ID: {Id}", reader.Id);
            _context.Readers.Update(reader);
            _context.SaveChanges();
        }

        public void DeleteReader(int id)
        {
            _logger.LogInformation("Удаление читателя ID: {Id}", id);
            var reader = _context.Readers.Find(id);
            if (reader != null)
            {
                _context.Readers.Remove(reader);
                _context.SaveChanges();
            }
        }

        public Reader ReadReaderById(int id)
        {
            return _context.Readers.AsNoTracking().FirstOrDefault(r => r.Id == id)!;
        }

        public IEnumerable<Reader> ReadReaders()
        {
            return _context.Readers.AsNoTracking().ToList();
        }
    }
}