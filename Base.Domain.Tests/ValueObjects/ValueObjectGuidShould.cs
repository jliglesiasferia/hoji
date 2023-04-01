namespace Base.Domain.Tests;

public class ValueObjectGuidShould
{
    [Test]
    public void Be_equal_to_its_guid()
    {
        var guid = Guid.NewGuid();
        var valueObject = SpecificValueObjectGuid.Create(guid);
        Assert.That(valueObject, Is.EqualTo(guid));
    }

    [Test]
    public void Print_its_value_when_is_converted_to_string()
    {
        var guid = Guid.NewGuid();
        var valueObject = SpecificValueObjectGuid.Create(guid);
        var printedValue = valueObject.ToString();
        Assert.That(printedValue, Is.EqualTo(guid.ToString()));
    }

    [Test]
    public void Be_equal_to_another_instance_with_the_same_guid()
    {
        var firstGuid = Guid.NewGuid();
        var secondGuid = firstGuid;
        var thirdGuid = Guid.NewGuid();
        var first = SpecificValueObjectGuid.Create(firstGuid);
        var second = SpecificValueObjectGuid.Create(secondGuid);
        var third = SpecificValueObjectGuid.Create(thirdGuid);

        Assert.That(first, Is.EqualTo(second));
        Assert.That(first == second, Is.True);
        Assert.That(first == third, Is.False);
    }

    [Test]
    public void Be_equal_to_the_same_guid()
    {
        var guid = Guid.NewGuid();
        var value = SpecificValueObjectGuid.Create(guid);

        Assert.That(value == guid, Is.True);
        Assert.That(value == Guid.NewGuid(), Is.False);

        Assert.That(guid == value, Is.True);
        Assert.That(Guid.NewGuid() == value, Is.False);
    }

    [Test]
    public void Be_different_to_another_instance_with_the_same_guid()
    {
        var firstGuid = Guid.NewGuid();
        var secondGuid = firstGuid;
        var thirdGuid = Guid.NewGuid();
        var first = SpecificValueObjectGuid.Create(firstGuid);
        var second = SpecificValueObjectGuid.Create(secondGuid);
        var third = SpecificValueObjectGuid.Create(thirdGuid);

        Assert.That(first, Is.Not.EqualTo(third));
        Assert.That(first != second, Is.False);
        Assert.That(first != third, Is.True);
    }

    [Test]
    public void Be_different_to_another_guid()
    {
        var guid = Guid.NewGuid();
        var value = SpecificValueObjectGuid.Create(guid);

        Assert.That(value != guid, Is.False);
        Assert.That(value != Guid.NewGuid(), Is.True);

        Assert.That(guid != value, Is.False);
        Assert.That(Guid.NewGuid() != value, Is.True);
    }
}
