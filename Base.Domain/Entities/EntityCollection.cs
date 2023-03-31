using System.Collections;

namespace Base.Domain;

public abstract class EntityCollection<T>
: IEnumerable
, IEnumerable<T>
{
    private List<T> _collection;

    protected EntityCollection()
    => _collection = new List<T>();

    public IEnumerator GetEnumerator()
    => ((IEnumerable)_collection).GetEnumerator();

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    => _collection.GetEnumerator();

    public void Add(T item)
    => _collection.Add(item);

    public void Remove(T item)
    => _collection.Remove(item);
}