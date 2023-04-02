
namespace Base.Domain.Tests;

internal record SpecificValueObjectInteger
: ValueObjectInteger
{
    private SpecificValueObjectInteger(int value)
    : base(value)
    { }

    public static SpecificValueObjectInteger Create(int value)
    => new SpecificValueObjectInteger(value);
}