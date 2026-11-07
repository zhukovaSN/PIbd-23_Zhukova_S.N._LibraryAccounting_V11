using System;

namespace LibraryAccounting.Entities
{
    public class Loan
    {
        public int Id { get; private set; }
        public int ReaderId { get; private set; }
        public int LibrarianId { get; private set; }
        public int LiteraryItemId { get; private set; }
        public DateTime LoanDate { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime? ReturnDate { get; private set; }

        public static Loan CreateOperation(int id, int readerId, int librarianId, int literaryItemId, DateTime dueDate)
        {
            return new Loan
            {
                Id = id,
                ReaderId = readerId,
                LibrarianId = librarianId,
                LiteraryItemId = literaryItemId,
                LoanDate = DateTime.Now, // Дата выдается автоматически
                DueDate = dueDate,
                ReturnDate = null
            };
        }
    }
}