namespace Base.Domain;

public abstract record ValueObjectString(string Value)
: ValueObject<string>(Value)
, IComparable<ValueObjectString>
{
    public int CompareTo(ValueObjectString? other)
    => Value.CompareTo(other?.Value);

    public static bool operator ==(ValueObjectString first, string second)
    => first.Value == second;

    public static bool operator !=(ValueObjectString first, string second)
    => first.Value != second;

    public static bool operator ==(string first, ValueObjectString second)
    => first == second.Value;

    public static bool operator !=(string first, ValueObjectString second)
    => first != second.Value;
}