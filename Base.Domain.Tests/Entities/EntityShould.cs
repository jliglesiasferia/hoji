namespace Base.Domain.Tests;

public class EntityShould
{
    [Test]
    public void Has_an_id_when_no_one_its_passed()
    {
        var entity = SpecificEntity.Create();
        Assert.That(entity.Id, Is.Not.Null);
        Assert.That(entity.Id.Value, Is.Not.Empty);
    }

    [Test]
    public void Has_the_indicated_id_when_is_passed()
    {
        var id = EntityId.Create();
        var entity = SpecificEntity.Create(id);
        Assert.That(entity.Id, Is.EqualTo(id));
    }
}
