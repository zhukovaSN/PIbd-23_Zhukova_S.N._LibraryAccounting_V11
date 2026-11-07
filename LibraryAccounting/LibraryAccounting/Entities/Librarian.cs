using LibraryAccounting.Entities.Enums;

namespace LibraryAccounting.Entities
{
    public class Librarian
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public LiteraryTheme AllowedThemes { get; private set; }

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