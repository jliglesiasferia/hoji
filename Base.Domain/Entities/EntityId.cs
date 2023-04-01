namespace Base.Domain;

public record EntityId
: ValueObjectGuid
{
    private EntityId(Guid guid)
    : base(guid)
    { }

    public static EntityId Create(Guid? guid = null)
    => new EntityId(guid ?? Guid.NewGuid());
}
