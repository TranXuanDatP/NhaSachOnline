using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhà_sách_Online.Models
{
    [Table("OrderStatus")]
    public class OrderStatus
    {
        public int Id {  get; set; }
        [Required]
        public string StatusId { get; set; }
        [Required]
        [MaxLength(20)]
        public string StatusName { get; set; }
    }
}
