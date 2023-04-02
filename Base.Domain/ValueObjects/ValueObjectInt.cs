namespace Base.Domain;

public abstract record ValueObjectInt(int Value)
: ValueObject<int>(Value)
, IEquatable<long>
, IEquatable<ulong>
, IEquatable<short>
, IEquatable<byte>
, IComparable<ValueObjectInt>
{
    public int CompareTo(ValueObjectInt? other)
    => Value.CompareTo(other?.Value);

    public bool Equals(long other)
    => Value == other;

    public bool Equals(ulong other)
    => (ulong)Value == other;

    public bool Equals(short other)
    => Value == other;

    public bool Equals(byte other)
    => Value == other;

    public static bool operator ==(ValueObjectInt first, long second)
    => first.Value == second;

    public static bool operator !=(ValueObjectInt first, long second)
    => first.Value != second;

    public static bool operator ==(long first, ValueObjectInt second)
    => first == second.Value;

    public static bool operator !=(long first, ValueObjectInt second)
    => first != second.Value;

    public static bool operator ==(ValueObjectInt first, ulong second)
    => (ulong)first.Value == second;

    public static bool operator !=(ValueObjectInt first, ulong second)
    => (ulong)first.Value != second;

    public static bool operator ==(ulong first, ValueObjectInt second)
    => first == (ulong)second.Value;

    public static bool operator !=(ulong first, ValueObjectInt second)
    => first != (ulong)second.Value;

    public static bool operator >(ValueObjectInt first, ValueObjectInt second)
    => first.Value > second.Value;

    public static bool operator >=(ValueObjectInt first, ValueObjectInt second)
    => first.Value >= second.Value;

    public static bool operator <(ValueObjectInt first, ValueObjectInt second)
    => first.Value < second.Value;

    public static bool operator <=(ValueObjectInt first, ValueObjectInt second)
    => first.Value <= second.Value;
}