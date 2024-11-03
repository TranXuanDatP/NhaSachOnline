using Microsoft.EntityFrameworkCore;
using Nhà_sách_Online.Data;
using Nhà_sách_Online.Models;

namespace Nhà_sách_Online.Respositories
{
    public class BookRepository : IBookRepository
    {
        
        private readonly ApplicationDbContext _dbContext;
        public BookRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddBook(Book book)
        {
            _dbContext.Books.Add(book); 
            await _dbContext.SaveChangesAsync();
        }
        public async Task RemoveBook(Book book)
        {
            _dbContext.Books.Remove(book);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateBook(Book book)
        {
            _dbContext.Books.Update(book);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<Book?> GetBook(int id) => await _dbContext.Books.FindAsync(id);
        public async Task<IEnumerable<Book>> GetBooks() => await _dbContext.Books.Include(g => g.Genre).ToListAsync();
    }
}
