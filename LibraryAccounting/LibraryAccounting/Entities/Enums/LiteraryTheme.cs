using System;

namespace LibraryAccounting.Entities.Enums
{
    [Flags]
    public enum LiteraryTheme
    {
        None = 0,
        Fiction = 1,      // Художественная
        Science = 2,      // Научная
        History = 4,      // Историческая
        Technology = 8    // Техническая
    }
}