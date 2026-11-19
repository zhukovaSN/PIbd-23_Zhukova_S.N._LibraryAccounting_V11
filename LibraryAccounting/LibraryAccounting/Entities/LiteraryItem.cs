using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibraryAccounting.Entities.Enums;

namespace LibraryAccounting.Entities
{
    public class LiteraryItem
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; private set; } = string.Empty;

        [Required]
        public LiteraryTheme Theme { get; private set; }

        [Required]
        public ItemType Type { get; private set; }

        protected LiteraryItem() { }

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