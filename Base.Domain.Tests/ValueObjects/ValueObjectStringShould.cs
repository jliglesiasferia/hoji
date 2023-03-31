namespace Base.Domain.Tests;

public class ValueObjectStringShould
{
    [Test]
    public void Be_equal_to_other_instance_with_the_same_string()
    {
        var firstValueObject = ValueObjectString.Create("some value");
        var secondValueObject = ValueObjectString.Create("some value");
        Assert.That(firstValueObject, Is.EqualTo(secondValueObject));

        var equality = firstValueObject == secondValueObject;
        Assert.That(equality, Is.True);
    }

    [Test]
    public void Be_different_when_another_instance_has_another_string()
    {
        var firstValueObject = ValueObjectString.Create("first value");
        var secondValueObject = ValueObjectString.Create("second value");
        Assert.That(firstValueObject, Is.Not.EqualTo(secondValueObject));

        var equality = firstValueObject == secondValueObject;
        Assert.That(equality, Is.False);
    }
}