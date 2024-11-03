using Nhà_sách_Online.Models;

namespace Nhà_sách_Online.Respositories
{
    public interface IBookRepository
    {
        Task AddBook(Book book);
        Task RemoveBook(Book book);
        Task<Book?> GetBook(int id);
        Task<IEnumerable<Book>> GetBooks();
        Task UpdateBook(Book book);
    }
}
