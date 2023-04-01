namespace Base.Domain.Tests;

public class ValueObjectStringShould
{
    [Test]
    public void Be_equal_to_other_instance_with_the_same_string()
    {
        var firstValueObject = SpecificValueObjectString.Create("some value");
        var secondValueObject = SpecificValueObjectString.Create("some value");
        Assert.That(firstValueObject, Is.EqualTo(secondValueObject));

        var equality = firstValueObject == secondValueObject;
        Assert.That(equality, Is.True);
    }

    [Test]
    public void Be_different_when_another_instance_has_another_string()
    {
        var firstValueObject = SpecificValueObjectString.Create("first value");
        var secondValueObject = SpecificValueObjectString.Create("second value");
        Assert.That(firstValueObject, Is.Not.EqualTo(secondValueObject));

        var equality = firstValueObject == secondValueObject;
        Assert.That(equality, Is.False);
    }

    [Test]
    public void Be_equal_to_its_string()
    {
        var objectValue = SpecificValueObjectString.Create("value");
        Assert.That(objectValue, Is.EqualTo("value"));
    }

    [Test]
    public void Be_able_to_be_ordered_by_its_strings()
    {
        var aValueObject = SpecificValueObjectString.Create("a");
        var bValueObject = SpecificValueObjectString.Create("b");
        var cValueObject = SpecificValueObjectString.Create("c");
        var zValueObject = SpecificValueObjectString.Create("z");
        var unorderedArray = new[]
        {
            cValueObject,
            zValueObject,
            bValueObject,
            aValueObject
        };
        
        var orderedArray = unorderedArray
            .OrderBy(x => x)
            .ToArray();

        Assert.That(orderedArray[0], Is.EqualTo(aValueObject));
        Assert.That(orderedArray[1], Is.EqualTo(bValueObject));
        Assert.That(orderedArray[2], Is.EqualTo(cValueObject));
        Assert.That(orderedArray[3], Is.EqualTo(zValueObject));
    }
}