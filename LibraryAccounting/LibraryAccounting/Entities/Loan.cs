using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAccounting.Entities
{
    public class Loan
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [ForeignKey("Reader")]
        public int ReaderId { get; private set; }

        [Required]
        [ForeignKey("Librarian")]
        public int LibrarianId { get; private set; }

        [Required]
        [ForeignKey("LiteraryItem")]
        public int LiteraryItemId { get; private set; }

        [Required]
        public DateTime LoanDate { get; private set; }

        [Required]
        public DateTime DueDate { get; private set; }

        public DateTime? ReturnDate { get; private set; }

        protected Loan() { }

        public static Loan CreateOperation(int id, int readerId, int librarianId, int literaryItemId, DateTime dueDate)
        {
            return new Loan
            {
                Id = id,
                ReaderId = readerId,
                LibrarianId = librarianId,
                LiteraryItemId = literaryItemId,
                LoanDate = DateTime.UtcNow,
                DueDate = dueDate,
                ReturnDate = null
            };
        }
    }
}