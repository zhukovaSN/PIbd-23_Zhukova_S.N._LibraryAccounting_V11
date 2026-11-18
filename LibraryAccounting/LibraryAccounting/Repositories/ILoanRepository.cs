using LibraryAccounting.Entities;
using System.Collections.Generic;

namespace LibraryAccounting.Repositories
{
    public interface ILoanRepository
    {
        IEnumerable<Loan> ReadLoans();
        void CreateLoan(Loan loan);
    }
}