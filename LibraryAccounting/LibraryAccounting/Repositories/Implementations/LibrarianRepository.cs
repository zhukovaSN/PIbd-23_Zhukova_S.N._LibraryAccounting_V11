using LibraryAccounting.Data;
using LibraryAccounting.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace LibraryAccounting.Repositories.Implementations
{
    internal class LibrarianRepository : ILibrarianRepository
    {
        private readonly LibraryContext _context;
        private readonly ILogger<LibrarianRepository> _logger;

        public LibrarianRepository(LibraryContext context, ILogger<LibrarianRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void CreateLibrarian(Librarian librarian)
        {
            _logger.LogInformation("Добавление библиотекаря: {LastName}", librarian.LastName);
            _context.Librarians.Add(librarian);
            _context.SaveChanges();
        }

        public void UpdateLibrarian(Librarian librarian)
        {
            _logger.LogInformation("Обновление библиотекаря ID: {Id}", librarian.Id);
            _context.Librarians.Update(librarian);
            _context.SaveChanges();
        }

        public void DeleteLibrarian(int id)
        {
            _logger.LogInformation("Удаление библиотекаря ID: {Id}", id);
            var librarian = _context.Librarians.Find(id);
            if (librarian != null)
            {
                _context.Librarians.Remove(librarian);
                _context.SaveChanges();
            }
        }

        public Librarian ReadLibrarianById(int id)
        {
            return _context.Librarians.AsNoTracking().FirstOrDefault(l => l.Id == id)!;
        }

        public IEnumerable<Librarian> ReadLibrarians()
        {
            return _context.Librarians.AsNoTracking().ToList();
        }
    }
}