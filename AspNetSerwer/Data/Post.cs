using System.ComponentModel.DataAnnotations;

namespace AspNetSerwer.Data
{
    public record Post
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Content { get; set; }
    }
}
