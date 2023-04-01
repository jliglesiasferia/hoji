namespace Base.Domain.Tests;

public class EntityIdShould
{
    [Test]
    public void Be_equal_to_its_id()
    {
        var id = Guid.NewGuid();
        var entityId = EntityId.Create(id);
        Assert.That(entityId, Is.EqualTo(id));
    }

    [Test]
    public void Print_its_value_when_is_converted_to_string()
    {
        var id = Guid.NewGuid();
        var entityId = EntityId.Create(id);
        var printedValue = entityId.ToString();
        Assert.That(printedValue, Is.EqualTo(id.ToString()));
    }
}
