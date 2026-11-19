using LibraryAccounting.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryAccounting.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<LiteraryItem> LiteraryItems { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<SupplyItem> SupplyItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=library_db;Username=postgres;Password=31052007s");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supply>()
                .HasOne<Librarian>()
                .WithMany()
                .HasForeignKey(s => s.LibrarianId);

            modelBuilder.Entity<Loan>()
                .HasOne<Reader>()
                .WithMany()
                .HasForeignKey(l => l.ReaderId);

            modelBuilder.Entity<Supply>()
                .HasMany(s => s.SupplyItems)
                .WithOne()
                .HasForeignKey(si => si.SupplyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SupplyItem>()
                .HasOne<LiteraryItem>()
                .WithMany()
                .HasForeignKey(si => si.LiteraryItemId);
        }
    }
}