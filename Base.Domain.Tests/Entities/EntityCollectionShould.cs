namespace Base.Domain.Tests;

public class EntityCollectionShould
{
    [Test]
    public void Add_new_items()
    {
        var collection = SpecificEntityCollection.Create();

        collection.Add(SpecificEntity.Create());
        Assert.That(collection, Has.Exactly(1).Items);

        collection.Add(SpecificEntity.Create());
        Assert.That(collection, Has.Exactly(2).Items);

        collection.Add(SpecificEntity.Create());
        Assert.That(collection, Has.Exactly(3).Items);
    }

    [Test]
    public void Remove_existing_items()
    {
        var first = SpecificEntity.Create();
        var second = SpecificEntity.Create();
        var third = SpecificEntity.Create();
        var collection = SpecificEntityCollection.Create();
        collection.Add(first);
        collection.Add(second);
        collection.Add(third);
        
        Assert.That(collection, Has.Exactly(3).Items);

        collection.Remove(first);
        Assert.That(collection, Has.Exactly(2).Items);

        collection.Remove(second);
        Assert.That(collection, Has.Exactly(1).Items);

        collection.Remove(third);
        Assert.That(collection, Has.Exactly(0).Items);
    }
}
