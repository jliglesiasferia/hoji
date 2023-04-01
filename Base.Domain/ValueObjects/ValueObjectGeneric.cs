namespace Base.Domain;

public abstract record ValueObject<T>(T Value)
: ValueObject
, IEquatable<T?>
{
    public sealed override string ToString()
    => Value?.ToString() ?? "";

    public bool Equals(T? value)
    => Value?.Equals(value) ?? false;
}