namespace Base.Domain;

public abstract record ValueObjectInteger(int Value)
: ValueObject<int>(Value)
, IEquatable<long>
, IEquatable<ulong>
, IEquatable<short>
, IEquatable<byte>
, IComparable<ValueObjectInteger>
{
    public int CompareTo(ValueObjectInteger? other)
    => Value.CompareTo(other?.Value);

    public bool Equals(long other)
    => Value == other;

    public bool Equals(ulong other)
    => (ulong)Value == other;

    public bool Equals(short other)
    => Value == other;

    public bool Equals(byte other)
    => Value == other;

    public static bool operator ==(ValueObjectInteger first, long second)
    => first.Value == second;

    public static bool operator !=(ValueObjectInteger first, long second)
    => first.Value != second;

    public static bool operator ==(long first, ValueObjectInteger second)
    => first == second.Value;

    public static bool operator !=(long first, ValueObjectInteger second)
    => first != second.Value;

    public static bool operator ==(ValueObjectInteger first, ulong second)
    => (ulong)first.Value == second;

    public static bool operator !=(ValueObjectInteger first, ulong second)
    => (ulong)first.Value != second;

    public static bool operator ==(ulong first, ValueObjectInteger second)
    => first == (ulong)second.Value;

    public static bool operator !=(ulong first, ValueObjectInteger second)
    => first != (ulong)second.Value;

    public static bool operator >(ValueObjectInteger first, ValueObjectInteger second)
    => first.Value > second.Value;

    public static bool operator >=(ValueObjectInteger first, ValueObjectInteger second)
    => first.Value >= second.Value;

    public static bool operator <(ValueObjectInteger first, ValueObjectInteger second)
    => first.Value < second.Value;

    public static bool operator <=(ValueObjectInteger first, ValueObjectInteger second)
    => first.Value <= second.Value;
}