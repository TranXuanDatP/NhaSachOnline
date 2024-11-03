using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhà_sách_Online.Models
{
    [Table("Order")]
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Required]
        public int OrderStatusId { get; set; }
        public bool IsDeleted { get; set; } = false;

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        [EmailAddress]
        [MaxLength(50)]
        [Required]
        public string? Email { get; set; }

        [MaxLength(20)]
        [Required]
        public string? PhoneNumber { get; set; }

        [MaxLength(250)]
        [Required]
        public string? Address { get; set; }

        [Required]
        [MaxLength(20)]
        public string? PaymentMethod { get; set; }
        public bool isPaid { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
