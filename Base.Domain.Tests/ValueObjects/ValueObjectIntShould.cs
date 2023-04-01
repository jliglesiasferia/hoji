namespace Base.Domain.Tests;

public class ValueObjectIntShould
{
    [Test]
    public void Be_equal_to_other_instance_with_the_same_integer()
    {
        var firstValueObject = SpecificValueObjectInt.Create(32);
        var secondValueObject = SpecificValueObjectInt.Create(32);
        Assert.That(firstValueObject, Is.EqualTo(secondValueObject));

        var equality = firstValueObject == secondValueObject;
        Assert.That(equality, Is.True);
    }

    [Test]
    public void Be_different_when_another_instance_has_another_integer()
    {
        var firstValueObject = SpecificValueObjectInt.Create(12);
        var secondValueObject = SpecificValueObjectInt.Create(23);
        Assert.That(firstValueObject, Is.Not.EqualTo(secondValueObject));

        var equality = firstValueObject == secondValueObject;
        Assert.That(equality, Is.False);
    }

    [Test]
    public void Be_equal_to_its_integer()
    {
        var objectValue = SpecificValueObjectInt.Create(333);
        Assert.That(objectValue, Is.EqualTo(333));
    }

    [Test]
    public void Print_its_value_when_its_converted_to_string()
    {
        var valueObject = SpecificValueObjectInt.Create(85);
        var printedValue = valueObject.ToString();
        Assert.That(printedValue, Is.EqualTo("85"));
    }

    [TestCase("1:-1", "-1:1")]
    [TestCase("2:0:1", "0:1:2")]
    [TestCase("100:32:0:-23:-333", "-333:-23:0:32:100")]
    public void Be_able_to_be_ordered_by_its_integers(
        string unordered,
        string ordered)
    {
        var result = string.Join(":", unordered
            .Split(":")
            .Select(value => 
                SpecificValueObjectInt.Create(int.Parse(value)))
            .OrderBy(x => x)
            .ToList());

        Assert.That(result, Is.EqualTo(ordered));
    }
}