namespace Base.Domain.Tests;

internal record SpecificValueObjectGuid
: ValueObjectGuid
{
    private SpecificValueObjectGuid(Guid guid)
    : base(guid)
    { }

    public static SpecificValueObjectGuid Create(Guid guid)
    => new SpecificValueObjectGuid(guid);
}