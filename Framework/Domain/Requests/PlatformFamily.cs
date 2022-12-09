namespace Retrobox.Framework.Domain;

public record PlatformFamily(string? Name, IReadOnlyCollection<Platform> Platforms);