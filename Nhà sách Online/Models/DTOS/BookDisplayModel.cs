namespace Nhà_sách_Online.Models.DTOS
{
    public class BookDisplayModel
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Book> Genres { get; set; }
        public string KeySearch { get; set; } = "";
        public int MaTheLoai { get; set; } = 0;
    }
}
