namespace Base.Domain.Tests;

public class ValueObjectDecmialShould
{[Test]
    public void Be_equal_to_its_decimal()
    {
        var valueObject = SpecificValueObjectDecimal.Create(12.3M);
        Assert.That(valueObject, Is.EqualTo(12.3M));
    }

    [Test]
    public void Print_its_value_when_is_converted_to_string()
    {
        var valueObject = SpecificValueObjectDecimal.Create(12.345M);
        Assert.That(valueObject.ToString(), Is.EqualTo("12,345"));
    }

    [Test]
    public void Be_equal_to_another_instance_with_the_same_decimal()
    {
        var first = SpecificValueObjectDecimal.Create(12.3M);
        var second = SpecificValueObjectDecimal.Create(12.3M);
        var third = SpecificValueObjectDecimal.Create(56.7M);

        Assert.That(first, Is.EqualTo(second));
        Assert.That(first == second, Is.True);
        Assert.That(first == third, Is.False);
    }

    [Test]
    public void Be_equal_to_the_same_decimal()
    {
        var value = SpecificValueObjectDecimal.Create(12.3M);

        Assert.That(value == 12.3M, Is.True);
        Assert.That(value == 56.7M, Is.False);

        Assert.That(12.3M == value, Is.True);
        Assert.That(56.7M == value, Is.False);
    }

    [Test]
    public void Be_different_to_another_instance_with_other_decimal()
    {
        var first = SpecificValueObjectDecimal.Create(12.3M);
        var second = SpecificValueObjectDecimal.Create(12.3M);
        var third = SpecificValueObjectDecimal.Create(56.7M);

        Assert.That(first, Is.Not.EqualTo(third));
        Assert.That(first != second, Is.False);
        Assert.That(first != third, Is.True);
    }

    [Test]
    public void Be_different_to_another_decimal()
    {
        var value = SpecificValueObjectDecimal.Create(12.3M);

        Assert.That(value != 12.3M, Is.False);
        Assert.That(value != 56.7M, Is.True);

        Assert.That(12.3M != value, Is.False);
        Assert.That(56.7M != value, Is.True);
    }

    [Test]
    public void Be_able_to_indicate_which_one_is_greater()
    {
        var first = SpecificValueObjectDecimal.Create(12.3M);
        var second = SpecificValueObjectDecimal.Create(23.4M);
        var third = SpecificValueObjectDecimal.Create(23.4M);
        var forth = SpecificValueObjectDecimal.Create(34.5M);

        Assert.That(second < first, Is.False);
        Assert.That(second < third, Is.False);
        Assert.That(second < forth, Is.True);

        Assert.That(second > first, Is.True);
        Assert.That(second > third, Is.False);
        Assert.That(second > forth, Is.False);
    }

    [Test]
    public void Be_able_to_indicate_which_one_is_greater_or_equal()
    {
        var first = SpecificValueObjectDecimal.Create(12.3M);
        var second = SpecificValueObjectDecimal.Create(23.4M);
        var third = SpecificValueObjectDecimal.Create(23.4M);
        var forth = SpecificValueObjectDecimal.Create(34.5M);

        Assert.That(second <= first, Is.False);
        Assert.That(second <= third, Is.True);
        Assert.That(second <= forth, Is.True);

        Assert.That(second >= first, Is.True);
        Assert.That(second >= third, Is.True);
        Assert.That(second >= forth, Is.False);
    }

    [TestCase("1,2:-1,2", "-1,2:1,2")]
    [TestCase("2,2:0,0:1,1", "0,0:1,1:2,2")]
    [TestCase("1,12:1,10:1,11", "1,10:1,11:1,12")]
    [TestCase("100,5:32,1:0,0:-23,45:-333,33", "-333,33:-23,45:0,0:32,1:100,5")]
    public void Be_able_to_be_ordered(
        string unordered,
        string ordered)
    {
        var result = string.Join(":", unordered
            .Split(":")
            .Select(value => SpecificValueObjectDecimal.Create(
                decimal.Parse(value)))
            .OrderBy(x => x)
            .ToList());

        Assert.That(result, Is.EqualTo(ordered));
    }
}
