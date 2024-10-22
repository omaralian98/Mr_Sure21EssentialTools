namespace Mr_Sure21EssentialTools;

public sealed record Error(string Code, string Description = "")
{
    public static readonly Error None = new(string.Empty, string.Empty);
}
