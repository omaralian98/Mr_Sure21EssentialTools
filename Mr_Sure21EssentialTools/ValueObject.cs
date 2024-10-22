namespace Mr_Sure21EssentialTools;

public abstract class ValueObject : IEquatable<ValueObject>
{
    public abstract IEnumerable<object> GetAtomicValues();

    public bool Equals(ValueObject? other)
    {
        if (other is null)
        {
            return false;
        }
        return AreValuesEqual(other);
    }

    public override int GetHashCode()
    {
        return GetAtomicValues().Aggregate(default(int), HashCode.Combine);
    }

    public override bool Equals(object? obj)
    {
        if (obj is ValueObject other)
        {
            return AreValuesEqual(other);
        }
        return false;
    }

    private bool AreValuesEqual(ValueObject other)
    {
        return GetAtomicValues().SequenceEqual(other.GetAtomicValues());
    }
}
