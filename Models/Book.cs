using System.ComponentModel.DataAnnotations;

namespace Example.Models
{
    public class Book
    {
        public Book() {}

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [StringLength(1000)]
        public string Summary { get; set; } = string.Empty;

        private DateTime _published;
        [DataType(DataType.Date)]
        public DateTime Published {
            get => _published;
            set => _published = DateTime.SpecifyKind(value, DateTimeKind.Utc);
        }
    }
}
