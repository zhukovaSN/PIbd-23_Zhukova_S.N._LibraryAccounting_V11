using System;

namespace LibraryAccounting.Entities.Enums
{
    [Flags]
    public enum LiteraryTheme
    {
        None = 0,
        Fiction = 1,      
        Science = 2,      
        History = 4,      
        Technology = 8    
    }
}