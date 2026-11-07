using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAccounting.Entities
{
    internal class Reader
    {
        public int Id { get; private set; }
        public string FullName { get; private set; } = string.Empty;
        public string TicketNumber { get; private set; } = string.Empty;
        public DateTime TicketValidUntil { get; private set; }

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
