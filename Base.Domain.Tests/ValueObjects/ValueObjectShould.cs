namespace Base.Domain.Tests;

public class ValueObjectShould
{
    [Test]
    public void Be_equal_to_other_instance_with_the_same_value()
    {
        var firstValueObject = new SpecificValueObject("some value");
        var secondValueObject = new SpecificValueObject("some value");
        Assert.That(firstValueObject, Is.EqualTo(secondValueObject));

        var equality = firstValueObject == secondValueObject;
        Assert.That(equality, Is.True);
    }

    [Test]
    public void Be_different_when_another_instance_has_another_value()
    {
        var firstValueObject = new SpecificValueObject("first value");
        var secondValueObject = new SpecificValueObject("second value");
        Assert.That(firstValueObject, Is.Not.EqualTo(secondValueObject));

        var equality = firstValueObject == secondValueObject;
        Assert.That(equality, Is.False);
    }
}