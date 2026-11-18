using LibraryAccounting.Entities;
using System.Collections.Generic;

namespace LibraryAccounting.Repositories
{
    public interface ILiteraryItemRepository
    {
        IEnumerable<LiteraryItem> ReadItems();
        LiteraryItem ReadItemById(int id);
        void CreateItem(LiteraryItem item);
        void UpdateItem(LiteraryItem item);
        void DeleteItem(int id);
    }
}