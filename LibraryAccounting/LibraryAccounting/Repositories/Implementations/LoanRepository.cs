using LibraryAccounting.Entities;
using System.Collections.Generic;

namespace LibraryAccounting.Repositories.Implementations
{
    internal class LoanRepository : ILoanRepository
    {
        public void CreateLoan(Loan loan)
        {
        }

        public IEnumerable<Loan> ReadLoans()
        {
            // Заглушка: возвращаем пустой список
            return new List<Loan>();
        }
    }
}