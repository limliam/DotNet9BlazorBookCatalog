using DotNet9BlazorBookCatalog.Domain.Entities;

namespace DotNet9BlazorBookCatalog.Application.Interfaces
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);

        Task<List<Book>> GetAllAsync();

        Task<Book?> GetByIdAsync(int id);

        Task UpdateAsync(Book book);

        Task DeleteByIdAsync(int id);
    }
}
