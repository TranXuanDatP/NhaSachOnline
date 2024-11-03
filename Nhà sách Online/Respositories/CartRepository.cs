/*using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Nhà_sách_Online.Data;
using Nhà_sách_Online.Models;
using Nhà_sách_Online.Models.DTOS;

namespace Nhà_sách_Online.Respositories
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CartRepository(ApplicationDbContext dbContext,
            IHttpContextAccessor IHttpContextAccessor, 
            UserManager<IdentityUser userManager>)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _httpContextAccessor = IHttpContextAccessor;
        }

        public async Task<ShoppingCart> GetCart(string userId)
        {
            var cart = await _dbContext.ShoppingCarts.FirstOrDefaultAsync(u => u.UserId == userId);
            return cart;
        }
        private string GetUserId()
        {
            var nhandiennguoidung = _httpContextAccessor.HttpContext.User;
            string userId = _userManager.GetUserId(nhandiennguoidung);
            return userId;

            var httpContext = _httpContextAccessor.HttpContext;
            if(httpContext?.User != null)
            {
                return _userManager.GetUserId(httpContext.User);
            }
            return null;
        }

        public async Task RemoveItem(int bookId)
        {
            throw new NotImplementedException();
        }

        public async Task<ShoppingCart> GetUserCart(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetCartItemCount(string userId = "")
        {
            throw new NotImplementedException();
        }

        public async Task UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DoCheckout(CheckoutModel model)
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            try
            {
                var userId = GetUserId();
                if(string.IsNullOrEmpty(userId))
                {
                    throw new UnauthorizedAccessException("Người dùng chưa đăng nhập");
                }
                var cart = await GetCart(userId);
                if (cart is null)
                {
                    throw new InvalidOperationException("lỗi, giỏ hàng trống");
                }
                var chitietgiohang = _dbContext.CartDetails
                    .Where(i => i.ShoppingCartId == cart.Id).ToList();
                if(chitietgiohang.Count == 0)
                {
                    throw new InvalidOperationException("giỏ hàng trống");
                }
                var trangthaidonhang = _dbContext.OrderStatuses
                    .FirstOrDefaultAsync(s => s.StatusName == "Pending");
                    if (chitietgiohang is null)
                {
                    throw new InvalidOperationException("Đơn hàng đang chờ xử lý");
                }
                var order = new Order
                {
                    UserId = userId,
                    CreateDate = DateTime.Now,
                    Name = model.Name,
                    Email = model.Email,
                    PhoneNumber = model.MobileNumber,
                    PaymentMethod = model.PaymentMethod,
                    Address = model.Address,
                    isPaid = false,
                    //OrderStatus = trangthaidonhang.Id,

                };
                _dbContext.Orders.Add(order);
                _dbContext.SaveChanges();

                foreach(var item in chitietgiohang)
                {
                    var chitietDonHang = new OrderDetail
                    {
                        BookId = item.BookId,
                        OrderId = order.Id,
                        Quantity = item.Quantity,
                        UnitPrice = item.UnitPrice,
                    };
                    *//*_dbContext.OrderDetails.Add();*//*
                }
            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public Task<int> AddItem(int bookId, int soluong)
        {
            throw new NotImplementedException();
        }
    }
}
*/