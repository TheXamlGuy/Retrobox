namespace Domain.Requests
{
    public record PlatformFamily(string? Name, IReadOnlyCollection<Platform> Platforms);
}