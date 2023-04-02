namespace Base.Domain;

public abstract record ValueObjectBoolean(bool Value)
: ValueObject<bool>(Value)
, IComparable<ValueObjectBoolean>
{
    public int CompareTo(ValueObjectBoolean? other)
    => Value.CompareTo(other?.Value);

    public static bool operator ==(ValueObjectBoolean first, bool second)
    => first.Value == second;

    public static bool operator !=(ValueObjectBoolean first, bool second)
    => first.Value != second;

    public static bool operator ==(bool first, ValueObjectBoolean second)
    => first == second.Value;

    public static bool operator !=(bool first, ValueObjectBoolean second)
    => first != second.Value;
}