namespace Base.Domain;

public abstract class Entity
{
    public Guid Id { get; private set; }

    protected Entity(Guid? guid = null)
    {
        Id = guid ?? Guid.NewGuid();
    }
}