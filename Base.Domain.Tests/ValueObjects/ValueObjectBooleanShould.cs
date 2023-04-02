namespace Base.Domain.Tests;

public class ValueObjectBooleanShould
{
    [Test]
    public void Be_equal_to_its_boolean()
    {
        var trueValue = SpecificValueObjectBoolean.Create(true);
        var falseValue = SpecificValueObjectBoolean.Create(false);

        Assert.That(trueValue, Is.EqualTo(true));
        Assert.That(falseValue, Is.EqualTo(false));
    }

    [Test]
    public void Print_its_value_when_is_converted_to_string()
    {
        var trueValue = SpecificValueObjectBoolean.Create(true);
        var falseValue = SpecificValueObjectBoolean.Create(false);

        var printedTrue = trueValue.ToString();
        var printedFalse = falseValue.ToString();

        Assert.That(printedTrue, Is.EqualTo("True"));
        Assert.That(printedFalse, Is.EqualTo("False"));
    }

    [Test]
    public void Be_equal_to_another_instance_with_the_same_boolean()
    {
        var first = SpecificValueObjectBoolean.Create(true);
        var second = SpecificValueObjectBoolean.Create(true);
        var third = SpecificValueObjectBoolean.Create(false);

        Assert.That(first, Is.EqualTo(second));
        Assert.That(first == second, Is.True);
        Assert.That(first == third, Is.False);
    }

    [Test]
    public void Be_equal_to_the_same_boolean()
    {
        var trueValue = SpecificValueObjectBoolean.Create(true);
        var falseValue = SpecificValueObjectBoolean.Create(false);

        Assert.That(trueValue == true, Is.True);
        Assert.That(trueValue == false, Is.False);

        Assert.That(true == trueValue, Is.True);
        Assert.That(false == trueValue, Is.False);

        Assert.That(falseValue == true, Is.False);
        Assert.That(falseValue == false, Is.True);

        Assert.That(true == falseValue, Is.False);
        Assert.That(false == falseValue, Is.True);
    }

    [Test]
    public void Be_different_to_another_instance_with_another_bolean()
    {
        var first = SpecificValueObjectBoolean.Create(true);
        var second = SpecificValueObjectBoolean.Create(true);
        var third = SpecificValueObjectBoolean.Create(false);
        
        Assert.That(first, Is.Not.EqualTo(third));
        Assert.That(first != second, Is.False);
        Assert.That(first != third, Is.True);
    }

    [Test]
    public void Be_different_to_another_boolean()
    {
        var trueValue = SpecificValueObjectBoolean.Create(true);
        var falseValue = SpecificValueObjectBoolean.Create(false);

        Assert.That(trueValue != true, Is.False);
        Assert.That(trueValue != false, Is.True);

        Assert.That(true != trueValue, Is.False);
        Assert.That(false != trueValue, Is.True);

        Assert.That(falseValue != true, Is.True);
        Assert.That(falseValue != false, Is.False);

        Assert.That(true != falseValue, Is.True);
        Assert.That(false != falseValue, Is.False);
    }

    [TestCase("true:false", "False:True")]
    [TestCase("true:false:false", "False:False:True")]
    [TestCase("true:false:true", "False:True:True")]
    [TestCase("true:false:true:false", "False:False:True:True")]
    public void Be_able_to_be_ordered_by_its_booleans(
        string unordered,
        string ordered)
    {
        var result = string.Join(":", unordered
            .Split(":")
            .Select(value => SpecificValueObjectBoolean.Create(
                bool.Parse(value)))
            .OrderBy(x => x)
            .ToList());

        Assert.That(result, Is.EqualTo(ordered));
    }
}
