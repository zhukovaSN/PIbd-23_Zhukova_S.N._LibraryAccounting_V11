using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAccounting.Entities
{
    public class Supply
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [ForeignKey("Librarian")]
        public int LibrarianId { get; private set; }

        [Required]
        public DateTime SupplyDate { get; private set; }

        public ICollection<SupplyItem> SupplyItems { get; private set; } = new List<SupplyItem>();

        protected Supply() { }

        public static Supply CreateOperation(int id, int librarianId, IEnumerable<SupplyItem> supplyItems)
        {
            return new Supply
            {
                Id = id,
                LibrarianId = librarianId,
                SupplyDate = DateTime.UtcNow,
                SupplyItems = new List<SupplyItem>(supplyItems)
            };
        }
    }
}