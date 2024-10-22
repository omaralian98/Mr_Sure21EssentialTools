namespace Mr_Sure21EssentialTools;

public abstract class Entity : Entity<int>
{

}

public abstract class Entity<TId> : IEquatable<Entity<TId>> where TId : struct, IEquatable<TId>
{
    public TId Id { get; set; }

    public bool Equals(Entity<TId>? other)
    {
        if (other is null)
        {
            return false;
        }
        return Id.Equals(other?.Id);
    }

    public override bool Equals(object? obj)
    {
        if (obj is Entity<TId> other)
        {
            return Equals(other);
        }
        return false;
    }

    public override int GetHashCode() => Id.GetHashCode();

    public static bool operator ==(Entity<TId> a, Entity<TId> b) => a.Equals(b);
    public static bool operator !=(Entity<TId> a, Entity<TId> b) => !(a.Equals(b));
}
