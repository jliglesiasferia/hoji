namespace Base.Domain;

public abstract record ValueObjectString(string Value)
: ValueObject<string>(Value)
, IComparable
, IComparable<string>
{
    public new int CompareTo(object? otherObject)
    => Value?.ToString()?.CompareTo(otherObject?.ToString()) ?? 0;

    public new int CompareTo(string? otherValue)
    => Value?.ToString()?.CompareTo(otherValue?.ToString()) ?? 0;
}