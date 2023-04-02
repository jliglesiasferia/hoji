namespace Base.Domain.Tests;

internal record SpecificValueObjectDecimal
: ValueObjectDecimal
{
    private SpecificValueObjectDecimal(decimal value)
    : base(value)
    { }

    public static SpecificValueObjectDecimal Create(decimal value)
    => new SpecificValueObjectDecimal(value);
}