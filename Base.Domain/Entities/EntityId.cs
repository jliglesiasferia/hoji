namespace Base.Domain;

public record EntityId(Guid Value)
: IEquatable<Guid>
{
    public static EntityId Create(Guid guid)
    => new EntityId(guid);

    public sealed override string ToString()
    => Value.ToString() ?? "";

    public bool Equals(Guid guid)
    => Value.Equals(guid);
}
