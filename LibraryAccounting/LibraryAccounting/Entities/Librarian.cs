using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibraryAccounting.Entities.Enums;

namespace LibraryAccounting.Entities
{
    public class Librarian
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; private set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string LastName { get; private set; } = string.Empty;

        [Required]
        public LiteraryTheme AllowedThemes { get; private set; }

        protected Librarian() { }

        public static Librarian CreateEntity(int id, string firstName, string lastName, LiteraryTheme allowedThemes)
        {
            return new Librarian
            {
                Id = id,
                FirstName = firstName ?? string.Empty,
                LastName = lastName ?? string.Empty,
                AllowedThemes = allowedThemes
            };
        }
    }
}