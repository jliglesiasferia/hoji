namespace Base.Domain;

public abstract record ValueObjectString(string Value)
: ValueObject<string>(Value)
, IComparable<ValueObjectString>
{
    public int CompareTo(ValueObjectString? other)
    => Value.CompareTo(other?.Value);
}