using DotNet9BlazorBookCatalog.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace DotNet9BlazorBookCatalog.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide a title")]
        [StringLength(100)]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Please provide the author's name")]
        [StringLength(100)]
        // Use Data annotation over fluent API 
        // StringLength vs MaxLength?? StringLength supports client side validation
        public string? Author { get; set; }

        public DateTime? PublicationDate { get; set; }

        [EnumDataType(typeof(Category), ErrorMessage = "Please select a category")]
        public Category Category { get; set; }
    }
}
