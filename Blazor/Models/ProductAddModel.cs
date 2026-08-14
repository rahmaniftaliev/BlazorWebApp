using System.ComponentModel.DataAnnotations;

namespace Blazor.Models
{
    public class ProductAddModel
    {
        [Required(ErrorMessage ="Product name is required")]
        [StringLength(20,ErrorMessage = "Character limit exceeded(Max 20)")]
        public string? ProductName { get; set; }

        [Required(ErrorMessage = "Product Description is required")]
        [StringLength(40, ErrorMessage = "Character limit exceeded(Max 40)")]
        public string? Description { get; set; }


        [Required(ErrorMessage = "CategoryId is required")]
        public string? CategoryId { get; set; }
    }
}
