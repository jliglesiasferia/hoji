
namespace Base.Domain.Tests;

internal record SpecificValueObjectString
: ValueObjectString
{
    private SpecificValueObjectString(string value)
    : base(value)
    { }

    public static SpecificValueObjectString Create(string value)
    => new SpecificValueObjectString(value);
}