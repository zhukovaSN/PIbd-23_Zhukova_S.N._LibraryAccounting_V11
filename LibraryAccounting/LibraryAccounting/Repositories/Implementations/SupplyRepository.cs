using LibraryAccounting.Entities;
using System.Collections.Generic;

namespace LibraryAccounting.Repositories.Implementations
{
    internal class SupplyRepository : ISupplyRepository
    {
        public void CreateSupply(Supply supply)
        {
        }

        public void DeleteSupply(int id)
        {
        }

        public IEnumerable<Supply> ReadSupplies()
        {
            // Заглушка: возвращаем пустой список
            return new List<Supply>();
        }
    }
}