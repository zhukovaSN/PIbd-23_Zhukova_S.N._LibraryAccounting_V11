using LibraryAccounting.Entities;
using System.Collections.Generic;

namespace LibraryAccounting.Repositories
{
    public interface ISupplyRepository
    {
        IEnumerable<Supply> ReadSupplies();
        void CreateSupply(Supply supply);
        void DeleteSupply(int id);
    }
}