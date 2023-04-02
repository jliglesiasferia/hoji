namespace Base.Domain;

public abstract record ValueObjectDecimal(decimal Value)
: ValueObject<decimal>(Value)
, IEquatable<float>
, IEquatable<double>
, IComparable<ValueObjectDecimal>
{
    public int CompareTo(ValueObjectDecimal? other)
    => Value.CompareTo(other?.Value);

    public bool Equals(float other)
    => ((float)Value).Equals(other);

    public bool Equals(double other)
    => ((double)Value).Equals(other);

    public static bool operator ==(ValueObjectDecimal first, decimal second)
    => first.Value == second;

    public static bool operator !=(ValueObjectDecimal first, decimal second)
    => first.Value != second;

    public static bool operator ==(decimal first, ValueObjectDecimal second)
    => first == second.Value;

    public static bool operator !=(decimal first, ValueObjectDecimal second)
    => first != second.Value;

    public static bool operator >(ValueObjectDecimal first, ValueObjectDecimal second)
    => first.Value > second.Value;

    public static bool operator >=(ValueObjectDecimal first, ValueObjectDecimal second)
    => first.Value >= second.Value;

    public static bool operator <(ValueObjectDecimal first, ValueObjectDecimal second)
    => first.Value < second.Value;

    public static bool operator <=(ValueObjectDecimal first, ValueObjectDecimal second)
    => first.Value <= second.Value;
}