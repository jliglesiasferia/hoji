namespace Base.Domain.Tests;

internal record SpecificValueObjectBoolean
: ValueObjectBoolean
{
    private SpecificValueObjectBoolean(bool value)
    : base(value)
    { }

    public static SpecificValueObjectBoolean Create(bool value)
    => new SpecificValueObjectBoolean(value);
}