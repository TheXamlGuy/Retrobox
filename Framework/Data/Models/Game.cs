using System.ComponentModel.DataAnnotations;

namespace Data
{
    public record class Game
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public int Rating { get; set; }

        public Guid PlatformId { get; set; }
    }
}
