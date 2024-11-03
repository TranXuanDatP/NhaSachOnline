using Nhà_sách_Online.Models;

namespace Nhà_sách_Online.Respositories
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Book>> LayThongTinSachTuDatabase(string keySearch = "", int MaTheLoai = 0);
        Task<IEnumerable<Genre>> Genres();
    }
}
