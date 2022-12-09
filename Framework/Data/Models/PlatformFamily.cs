﻿using System.ComponentModel.DataAnnotations;

namespace Data
{
    public record class PlatformFamily
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public List<Platform> Platforms { get; } = new();
    }
}
