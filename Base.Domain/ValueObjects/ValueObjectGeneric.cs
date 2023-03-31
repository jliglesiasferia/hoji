namespace Base.Domain;

public abstract record ValueObject<T>
: ValueObject
, IEquatable<T?>
, IComparable
, IComparable<T?>
{
    private T _value;

    protected ValueObject(T value)
    => _value = value;

    public override string ToString()
    => _value?.ToString() ?? "";

    public bool Equals(T? str)
    => _value?.Equals(str) ?? false;

    public override int GetHashCode()
    => _value?.GetHashCode() ?? 0;

    public int CompareTo(T? otherValue)
    => _value?.ToString()?.CompareTo(otherValue) ?? 0;

    public int CompareTo(object? otherObject)
    => _value?.ToString()?.CompareTo(otherObject) ?? 0;
}