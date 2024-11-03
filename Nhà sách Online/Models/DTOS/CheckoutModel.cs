using System.ComponentModel.DataAnnotations;

namespace Nhà_sách_Online.Models.DTOS
{
    public class CheckoutModel
    {
        [Required]
        [MaxLength(20)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(20)]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]

        public string? MobileNumber { get; set; }
        [Required]
        [MaxLength(20)]
        public string Address { get; set; }

        [Required]
        public string? PaymentMethod {  get; set; }
    }
}
