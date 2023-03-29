namespace Decks.Commands.Domain;

public abstract class EntityCollection<T>
{
    private List<T> _collection;

    protected EntityCollection()
    => _collection = new List<T>();

    public void Add(T item)
    => _collection.Add(item);
}