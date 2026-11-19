using LibraryAccounting.Data;
using LibraryAccounting.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryAccounting.Repositories.Implementations
{
    internal class SupplyRepository : ISupplyRepository
    {
        private readonly LibraryContext _context;
        private readonly ILogger<SupplyRepository> _logger;

        public SupplyRepository(LibraryContext context, ILogger<SupplyRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void CreateSupply(Supply supply)
        {
            _logger.LogInformation("Создание поставки для библиотекаря ID: {LibrarianId}", supply.LibrarianId);
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Supplies.Add(supply);
                _context.SaveChanges();
                transaction.Commit();
                _logger.LogInformation("Поставка успешно сохранена");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                _logger.LogError(ex, "Ошибка при создании поставки. Транзакция отменена.");
                throw;
            }
        }

        public void DeleteSupply(int id)
        {
            _logger.LogInformation("Удаление поставки ID: {Id}", id);
            var supply = _context.Supplies.Find(id);
            if (supply != null)
            {
                _context.Supplies.Remove(supply);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Supply> ReadSupplies()
        {
            return _context.Supplies.Include(s => s.SupplyItems).AsNoTracking().ToList();
        }
    }
}