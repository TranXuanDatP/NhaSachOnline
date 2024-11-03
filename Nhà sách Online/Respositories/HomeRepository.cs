using Microsoft.EntityFrameworkCore;
using Nhà_sách_Online.Data;
using Nhà_sách_Online.Models;

namespace Nhà_sách_Online.Respositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public HomeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Genre>> Genres()
        {
            return await _dbContext.Genres.ToListAsync();
        }

        //public void GetBooks(string keySearch = "", int MaTheLoai = 0)
        //{
        //    //chuyển đổi chuỗi keySearch sang dạng chữ thường (lowercase)
        //    keySearch = keySearch.ToLower();

        //    var sachs = (from sach in _dbContext.DbSetSach
        //                 join TheLoai in _dbContext.DbSetTheLoai
        //                 on sach.MaTheLoai equals TheLoai.MaTheLoai

        //                 select new Sach
        //                 {
        //                     MaSach = sach.MaSach,
        //                     HinhAnh = sach.HinhAnh,
        //                     TenTacGia = sach.TenTacGia,
        //                     Gia = sach.Gia,
        //                     MaTheLoai = sach.MaTheLoai,
        //                     TenTheLoai = sach.TenTheLoai,
        //                 }
        //                 );
        //}
        // Lấy thông tin sách từ csdl
        public async Task<IEnumerable<Book>> LayThongTinSachTuDatabase(string keySearch = "", int MaTheLoai = 0)
        {
            //chuyển đổi chuỗi keySearch sang dạng chữ thường (lowercase)
            keySearch = keySearch.ToLower();

            IEnumerable<Book> books = await (from sach in _dbContext.Books
                                             join TheLoai in _dbContext.Genres
                                             on sach.GenreId equals TheLoai.Id
                                             where string.IsNullOrWhiteSpace(keySearch) || (sach != null && sach.BookName != null && sach.BookName.ToLower().StartsWith(keySearch.ToLower()))
                                             select new Book
                                             {
                                                 Id = sach.Id,
                                                 BookName = sach.BookName,
                                                 Image = sach.Image,
                                                 AuthorName = sach.AuthorName,
                                                 Price = sach.Price,
                                                 GenreId = sach.GenreId,
                                                 GenreName = sach.GenreName,
                                                 Quantity = sach.Quantity,
                                             }
                         ).ToListAsync();
            return books;
        }
    }
}
