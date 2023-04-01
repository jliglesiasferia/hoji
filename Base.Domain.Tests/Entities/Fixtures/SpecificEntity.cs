namespace Base.Domain.Tests;

internal class SpecificEntity
: Entity
{
    private SpecificEntity(EntityId? id = null)
    : base(id)
    { }

    public static SpecificEntity Create(EntityId? id = null)
    => new SpecificEntity(id);
}
