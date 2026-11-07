using LibraryAccounting.Entities.Enums;

namespace LibraryAccounting.Entities
{
    public class LiteraryItem
    {
        public int Id { get; private set; }
        public string Title { get; private set; } = string.Empty;
        public LiteraryTheme Theme { get; private set; }
        public ItemType Type { get; private set; }

        public static LiteraryItem CreateEntity(int id, string title, LiteraryTheme theme, ItemType type)
        {
            return new LiteraryItem
            {
                Id = id,
                Title = title ?? string.Empty,
                Theme = theme,
                Type = type
            };
        }
    }
}