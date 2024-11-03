using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhà_sách_Online.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id {  get; set; }
        [MaxLength(100)]
        [Required]
        public string? BookName { get; set;}
        [MaxLength(100)]
        [Required]
        public string? AuthorName {  get; set;}
        [Required]
        public double Price { get; set;}
        [Required]

        public string? Image {  get; set; }

        public int GenreId { get; set; }
        /*public int MaTheLoai { get; set; }*/
        public Genre Genre { get; set; }

        public List<CartDetail> CartDetails { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public Stock Stock { get; set; }

        [NotMapped]
        public string GenreName { get; set; }

        [NotMapped]
        public string Quantity { get; set; }
    }
}
