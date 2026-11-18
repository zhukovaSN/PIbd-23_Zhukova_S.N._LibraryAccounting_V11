using System;
using System.Collections.Generic;

namespace LibraryAccounting.Entities
{
    public class Supply
    {
        public int Id { get; private set; }
        public int LibrarianId { get; private set; }
        public DateTime SupplyDate { get; private set; }
        public IEnumerable<SupplyItem> SupplyItems { get; private set; } = new List<SupplyItem>();

        public static Supply CreateOperation(int id, int librarianId, IEnumerable<SupplyItem> supplyItems)
        {
            return new Supply
            {
                Id = id,
                LibrarianId = librarianId,
                SupplyDate = DateTime.Now,
                SupplyItems = supplyItems
            };
        }
    }
}