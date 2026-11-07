namespace LibraryAccounting.Entities
{
    public class SupplyItem
    {
        public int Id { get; private set; }
        public int LiteraryItemId { get; private set; }
        public int Count { get; private set; }

        public static SupplyItem CreateElement(int id, int literaryItemId, int count)
        {
            return new SupplyItem
            {
                Id = id,
                LiteraryItemId = literaryItemId,
                Count = count
            };
        }
    }
}