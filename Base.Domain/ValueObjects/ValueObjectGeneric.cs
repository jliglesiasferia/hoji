namespace Base.Domain;

public abstract record ValueObject<T>(T Value)
: ValueObject
, IEquatable<T?>
{
    public bool Equals(T? value)
    => Value?.Equals(value) ?? false;

    public sealed override string ToString()
    => Value?.ToString() ?? "";
}