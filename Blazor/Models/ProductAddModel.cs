using System.ComponentModel.DataAnnotations;

namespace Blazor.Models
{
    public class ProductAddModel
    {
        [Required]
        public string? ProductName { get; set; }
        [Required]
        public string? Description { get; set; }
    }
}
