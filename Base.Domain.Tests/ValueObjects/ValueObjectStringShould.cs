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
    public void Print_its_value_when_its_converted_to_string()
    {
        var valueObject = SpecificValueObjectString.Create("printed value");
        var printedValue = valueObject.ToString();
        Assert.That(printedValue, Is.EqualTo("printed value"));
    }

    [TestCase("   : ", " :   ")]
    [TestCase("a: ", " :a")]
    [TestCase("aaa:a", "a:aaa")]
    [TestCase("b:a", "a:b")]
    [TestCase("A:a", "a:A")]
    [TestCase("c:z:b:a", "a:b:c:z")]
    [TestCase("3: :A:a:$", " :$:3:a:A")]
    public void Be_able_to_be_ordered_by_its_strings(
        string unordered,
        string ordered)
    {
        var result = string.Join(":", unordered
            .Split(":")
            .Select(value => SpecificValueObjectString.Create(value))
            .OrderBy(x => x)
            .ToList());

        Assert.That(result, Is.EqualTo(ordered));
    }
}