using LibraryAccounting.Data;
using LibraryAccounting.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace LibraryAccounting.Repositories.Implementations
{
    internal class LoanRepository : ILoanRepository
    {
        private readonly LibraryContext _context;
        private readonly ILogger<LoanRepository> _logger;

        public LoanRepository(LibraryContext context, ILogger<LoanRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void CreateLoan(Loan loan)
        {
            _logger.LogInformation("Оформление выдачи читателю ID: {ReaderId}", loan.ReaderId);
            _context.Loans.Add(loan);
            _context.SaveChanges();
        }

        public IEnumerable<Loan> ReadLoans()
        {
            return _context.Loans.AsNoTracking().ToList();
        }
    }
}