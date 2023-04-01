namespace Base.Domain;

public abstract record ValueObjectGuid(Guid Value)
: ValueObject<Guid>(Value)
, IComparable<ValueObjectGuid>
{
    public int CompareTo(ValueObjectGuid? other)
    => Value.CompareTo(other?.Value);

    public static bool operator ==(ValueObjectGuid first, Guid second)
    => first.Value == second;

    public static bool operator !=(ValueObjectGuid first, Guid second)
    => first.Value != second;

    public static bool operator ==(Guid first, ValueObjectGuid second)
    => first == second.Value;

    public static bool operator !=(Guid first, ValueObjectGuid second)
    => first != second.Value;
}