using DotNet9BlazorBookCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotNet9BlazorBookCatalog.Infrastructure.Context
{
    public class BookCatalogDbContext : DbContext
    {
        public BookCatalogDbContext(DbContextOptions<BookCatalogDbContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }

        // We don't use this fluent API because we use Data Annotation directly on the Book class. See Book.cs
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Book>().Property(e => e.Title).IsRequired().HasMaxLength(100);
        //    modelBuilder.Entity<Book>().Property(e => e.Author).IsRequired().HasMaxLength(100);
        //}

    }
}
