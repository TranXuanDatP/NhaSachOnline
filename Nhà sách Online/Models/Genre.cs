using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhà_sách_Online.Models
{
    [Table("Genre")]
    public class Genre
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string? GenreName { get; set; }
        public List<Book>Books { get; set; }
    }
}
