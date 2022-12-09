using System.ComponentModel.DataAnnotations;

namespace Data
{
    public record class Platform
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public Guid FamilyId { get; set; }

        public PlatformFamily? Family { get; set; }

        public List<Game> Games { get; } = new();
    }
}
