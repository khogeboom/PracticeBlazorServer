using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class MilkshakeModel
    {
        [Required]
        [MinLength(1, ErrorMessage = "You need to select a type of milkshake")]
        public string TypeOfMilkshake { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "You need to select a milkshake size")]
        public string Size { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "You need to give us a name for the order")]
        public string Name { get; set; }

        [Range(1, 10, ErrorMessage = "Please give us a number between 1 and 10")]
        public int Quantity { get; set; }

        public bool AddWhippedCream { get; set; }

    }
}
