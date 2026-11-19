using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAccounting.Entities
{
    public class Reader
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [Column("FullName")]
        [MaxLength(255)]
        public string FullName { get; private set; } = string.Empty;

        [Required]
        [Column("TicketNumber")]
        [MaxLength(50)]
        public string TicketNumber { get; private set; } = string.Empty;

        [Required]
        public DateTime TicketValidUntil { get; private set; }

        protected Reader() { }

        public static Reader CreateEntity(int id, string fullName, string ticketNumber, DateTime ticketValidUntil)
        {
            return new Reader
            {
                Id = id,
                FullName = fullName ?? string.Empty,
                TicketNumber = ticketNumber ?? string.Empty,
                TicketValidUntil = ticketValidUntil
            };
        }
    }
}