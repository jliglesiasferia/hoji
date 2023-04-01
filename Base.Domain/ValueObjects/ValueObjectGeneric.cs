namespace Base.Domain;

public abstract record ValueObject<T>(T Value)
: ValueObject
, IEquatable<T?>
, IComparable
, IComparable<T>
{
    public bool Equals(T? value)
    => Value?.Equals(value) ?? false;

    public int CompareTo(object? otherObject)
    => Value?.ToString()?.CompareTo(otherObject?.ToString()) ?? 0;

    public int CompareTo(T? otherValue)
    => Value?.ToString()?.CompareTo(otherValue?.ToString()) ?? 0;
}