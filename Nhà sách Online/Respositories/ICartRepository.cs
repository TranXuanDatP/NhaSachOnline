using Nhà_sách_Online.Models;
using Nhà_sách_Online.Models.DTOS;

namespace Nhà_sách_Online.Respositories
{
    public interface ICartRepository
    {
        Task<int> AddItem(int bookId, int soluong);
        Task RemoveItem(int bookId);
        Task<ShoppingCart> GetUserCart(int id);
        Task<ShoppingCart> GetCart(string userId);
        Task<int> GetCartItemCount (string userId = "");
        Task<bool> DoCheckout(CheckoutModel model);
        Task UpdateBook(Book book);
    }
}
