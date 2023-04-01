namespace Base.Domain.Tests;

public class ValueObjectIntShould
{
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
        Assert.That(valueObject.ToString(), Is.EqualTo("85"));
    }

    [Test]
    public void Be_equal_compared_with_another_instance_with_the_same_integer()
    {
        var first = SpecificValueObjectInt.Create(32);
        var second = SpecificValueObjectInt.Create(32);
        var third = SpecificValueObjectInt.Create(12);

        Assert.That(first, Is.EqualTo(second));
        Assert.That(first == second, Is.True);
        Assert.That(first == third, Is.False);
    }

    [Test]
    public void Be_equal_compared_with_the_same_number()
    {
        var value = SpecificValueObjectInt.Create(32);

        Assert.That(value, Is.EqualTo(32));
        Assert.That(value, Is.EqualTo(32L));
        Assert.That(value, Is.EqualTo((short)32));
        Assert.That(value, Is.EqualTo((byte)32));

        Assert.That(value == 32, Is.True);
        Assert.That(value == 11, Is.False);

        Assert.That(32 == value, Is.True);
        Assert.That(11 == value, Is.False);

        Assert.That(value == 32L, Is.True);
        Assert.That(value == 11L, Is.False);

        Assert.That(32L == value, Is.True);
        Assert.That(11L == value, Is.False);

        Assert.That(value == 32U, Is.True);
        Assert.That(value == 11U, Is.False);

        Assert.That(32U == value, Is.True);
        Assert.That(11U == value, Is.False);

        Assert.That(value == 32UL, Is.True);
        Assert.That(value == 11UL, Is.False);

        Assert.That(32UL == value, Is.True);
        Assert.That(11UL == value, Is.False);

        Assert.That(((short)32) == value, Is.True);
        Assert.That(((short)11) == value, Is.False);

        Assert.That(value == ((short)32), Is.True);
        Assert.That(value == ((short)11), Is.False);

        Assert.That(((byte)32) == value, Is.True);
        Assert.That(((byte)11) == value, Is.False);

        Assert.That(value == ((byte)32), Is.True);
        Assert.That(value == ((byte)11), Is.False);
    }

    [Test]
    public void Be_different_compared_with_another_instance_with_other_integer()
    {
        var first = SpecificValueObjectInt.Create(32);
        var second = SpecificValueObjectInt.Create(32);
        var third = SpecificValueObjectInt.Create(12);

        Assert.That(first, Is.Not.EqualTo(third));
        Assert.That(first != second, Is.False);
        Assert.That(first != third, Is.True);
    }

    [Test]
    public void Be_different_compared_with_another_number()
    {
        var value = SpecificValueObjectInt.Create(32);

        Assert.That(value != 32, Is.False);
        Assert.That(value != 11, Is.True);

        Assert.That(32 != value, Is.False);
        Assert.That(11 != value, Is.True);

        Assert.That(value != 32L, Is.False);
        Assert.That(value != 11L, Is.True);

        Assert.That(32L != value, Is.False);
        Assert.That(11L != value, Is.True);

        Assert.That(value != 32U, Is.False);
        Assert.That(value != 11U, Is.True);

        Assert.That(32U != value, Is.False);
        Assert.That(11U != value, Is.True);

        Assert.That(value != 32UL, Is.False);
        Assert.That(value != 11UL, Is.True);

        Assert.That(32UL != value, Is.False);
        Assert.That(11UL != value, Is.True);

        Assert.That(((short)32) != value, Is.False);
        Assert.That(((short)11) != value, Is.True);

        Assert.That(value != ((short)32), Is.False);
        Assert.That(value != ((short)11), Is.True);

        Assert.That(((byte)32) != value, Is.False);
        Assert.That(((byte)11) != value, Is.True);

        Assert.That(value != ((byte)32), Is.False);
        Assert.That(value != ((byte)11), Is.True);
    }

    [Test]
    public void Be_able_to_indicate_which_one_is_greater()
    {
        var first = SpecificValueObjectInt.Create(12);
        var second = SpecificValueObjectInt.Create(23);
        var third = SpecificValueObjectInt.Create(23);
        var forth = SpecificValueObjectInt.Create(34);

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
        var first = SpecificValueObjectInt.Create(12);
        var second = SpecificValueObjectInt.Create(23);
        var third = SpecificValueObjectInt.Create(23);
        var forth = SpecificValueObjectInt.Create(34);

        Assert.That(second <= first, Is.False);
        Assert.That(second <= third, Is.True);
        Assert.That(second <= forth, Is.True);

        Assert.That(second >= first, Is.True);
        Assert.That(second >= third, Is.True);
        Assert.That(second >= forth, Is.False);
    }

    [TestCase("1:-1", "-1:1")]
    [TestCase("2:0:1", "0:1:2")]
    [TestCase("100:32:0:-23:-333", "-333:-23:0:32:100")]
    public void Be_able_to_be_ordered(
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