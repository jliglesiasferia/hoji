
namespace Base.Domain.Tests;

internal record SpecificValueObjectInt
: ValueObjectInt
{
    private SpecificValueObjectInt(int value)
    : base(value)
    { }

    public static SpecificValueObjectInt Create(int value)
    => new SpecificValueObjectInt(value);
}