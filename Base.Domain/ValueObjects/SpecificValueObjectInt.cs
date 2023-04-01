namespace Base.Domain;

public abstract record ValueObjectInt(int Value)
: ValueObject<int>(Value)
, IComparable<ValueObjectInt>
{
    public int CompareTo(ValueObjectInt? other)
    => Value.CompareTo(other?.Value);
}