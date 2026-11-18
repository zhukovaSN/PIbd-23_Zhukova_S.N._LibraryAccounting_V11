using LibraryAccounting.Entities;
using LibraryAccounting.Entities.Enums;
using System.Collections.Generic;

namespace LibraryAccounting.Repositories.Implementations
{
    internal class LiteraryItemRepository : ILiteraryItemRepository
    {
        public void CreateItem(LiteraryItem item)
        {
        }

        public void DeleteItem(int id)
        {
        }

        public LiteraryItem ReadItemById(int id)
        {
            return LiteraryItem.CreateEntity(0, string.Empty, LiteraryTheme.None, ItemType.None);
        }

        public IEnumerable<LiteraryItem> ReadItems()
        {
            return new List<LiteraryItem>();
        }

        public void UpdateItem(LiteraryItem item)
        {
        }
    }
}