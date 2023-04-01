namespace Base.Domain.Tests;

public class ValueObjectStringShould
{
    [Test]
    public void Be_equal_to_its_string()
    {
        var valueObject = SpecificValueObjectString.Create("value");
        Assert.That(valueObject, Is.EqualTo("value"));
    }

    [Test]
    public void Print_its_value_when_is_converted_to_string()
    {
        var valueObject = SpecificValueObjectString.Create("printed value");
        var printedValue = valueObject.ToString();
        Assert.That(printedValue, Is.EqualTo("printed value"));
    }

    [Test]
    public void Be_equal_to_another_instance_with_the_same_string()
    {
        var first = SpecificValueObjectString.Create("same value");
        var second = SpecificValueObjectString.Create("same value");
        var third = SpecificValueObjectString.Create("other value");

        Assert.That(first, Is.EqualTo(second));
        Assert.That(first == second, Is.True);
        Assert.That(first == third, Is.False);
    }

    [Test]
    public void Be_equal_to_the_same_string()
    {
        var value = SpecificValueObjectString.Create("value");

        Assert.That(value == "value", Is.True);
        Assert.That(value == "other", Is.False);

        Assert.That("value" == value, Is.True);
        Assert.That("other" == value, Is.False);
    }

    [Test]
    public void Be_different_to_another_instance_with_another_string()
    {
        var first = SpecificValueObjectString.Create("same value");
        var second = SpecificValueObjectString.Create("same value");
        var third = SpecificValueObjectString.Create("other value");
        
        Assert.That(first, Is.Not.EqualTo(third));
        Assert.That(first != second, Is.False);
        Assert.That(first != third, Is.True);
    }

    [Test]
    public void Be_different_to_another_string()
    {
        var value = SpecificValueObjectString.Create("value");

        Assert.That(value != "value", Is.False);
        Assert.That(value != "other", Is.True);

        Assert.That("value" != value, Is.False);
        Assert.That("other" != value, Is.True);
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