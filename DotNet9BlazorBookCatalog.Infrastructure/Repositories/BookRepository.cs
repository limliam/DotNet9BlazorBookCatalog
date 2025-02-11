using DotNet9BlazorBookCatalog.Application.Interfaces;
using DotNet9BlazorBookCatalog.Domain.Entities;
using DotNet9BlazorBookCatalog.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace DotNet9BlazorBookCatalog.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookCatalogDbContext context;

        public BookRepository(IDbContextFactory<BookCatalogDbContext> factory)
        {
            context = factory.CreateDbContext();
        }
        public async Task AddAsync(Book book)
        {
            context.Books.Add(book);
            await context.SaveChangesAsync();
        }
        public async Task DeleteByIdAsync(int id)
        {
            var book = await GetByIdAsync(id);
            if (book is not null)
            {
                context.Books.Remove(book);
                await context.SaveChangesAsync();
            }
        }
        public async Task<List<Book>> GetAllAsync()
        {
            var books = await context.Books.ToListAsync();
            return books;
        }
        public async Task<Book?> GetByIdAsync(int id)
        {
            var book = await context.Books.FirstOrDefaultAsync(x => x.Id == id);
            return book;
        }
        public async Task UpdateAsync(Book book)
        {
            context.Entry(book).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
