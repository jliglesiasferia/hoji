namespace Base.Domain;

public abstract class Entity
{
    public EntityId Id { get; private set; }

    protected Entity(EntityId? id = null)
    => Id = id ?? EntityId.Create();
}