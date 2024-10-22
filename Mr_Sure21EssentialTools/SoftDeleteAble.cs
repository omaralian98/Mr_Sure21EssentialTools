namespace Mr_Sure21EssentialTools;

public abstract class SoftDeleteAble : SoftDeleteAble<int>
{
}

public abstract class SoftDeleteAble<TId> : Entity<TId> where TId : struct, IEquatable<TId>
{
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedOn { get; set; } = null;
}
