namespace Base.Domain;

public record ValueObjectString
: ValueObject<string>
{
    private ValueObjectString(string value)
    : base(value)
    { }

    public static ValueObjectString Create(string value)
    => new ValueObjectString(value);
}