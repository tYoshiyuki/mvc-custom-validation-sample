using MvcCustomValidation.Attribute;
using System.ComponentModel.DataAnnotations;

namespace MvcCustomValidation.Models
{
    public class Book
    {
        [Required]
        [ScaffoldColumn(false)]
        public int id { get; set; }

        [Required]
        [AlphaNumeric]
        public string Title { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string Isbn { get; set; }
    }
}