using System.ComponentModel.DataAnnotations;

namespace Data
{
    public record class Platform
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Family { get; set; }

        public List<Game> Games { get; } = new();
    }
}
