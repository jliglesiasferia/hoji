namespace Base.Domain.Tests;

internal class SpecificEntityCollection
: EntityCollection<SpecificEntity>
{
    private SpecificEntityCollection()
    : base()
    { }

    public static SpecificEntityCollection Create()
    => new SpecificEntityCollection();
}
