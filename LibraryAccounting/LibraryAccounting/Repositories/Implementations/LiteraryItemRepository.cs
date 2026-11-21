using LibraryAccounting.Data;
using LibraryAccounting.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace LibraryAccounting.Repositories.Implementations
{
    internal class LiteraryItemRepository : ILiteraryItemRepository
    {
        private readonly LibraryContext _context;
        private readonly ILogger<LiteraryItemRepository> _logger;

        public LiteraryItemRepository(LibraryContext context, ILogger<LiteraryItemRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void CreateItem(LiteraryItem item)
        {
            _logger.LogInformation("Добавление издания: {Title}", item.Title);
            _context.LiteraryItems.Add(item);
            _context.SaveChanges();
        }

        public void UpdateItem(LiteraryItem item)
        {
            _logger.LogInformation("Обновление издания ID: {Id}", item.Id);
            _context.LiteraryItems.Update(item);
            _context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            _logger.LogInformation("Удаление издания ID: {Id}", id);
            var item = _context.LiteraryItems.Find(id);
            if (item != null)
            {
                _context.LiteraryItems.Remove(item);
                _context.SaveChanges();
            }
        }

        public LiteraryItem ReadItemById(int id)
        {
            return _context.LiteraryItems.AsNoTracking().FirstOrDefault(i => i.Id == id)!;
        }

        public IEnumerable<LiteraryItem> ReadItems()
        {
            return _context.LiteraryItems.AsNoTracking().ToList();
        }
    }
}