namespace Decks.Commands.Domain;

public class CardShould
{
    [Test]
    public void Throw_an_exception_when_anverse_or_reverse_are_empty()
    {
        Assert.Throws<CardPairEmpty>(() => CardPair.Create("", ""));
        Assert.Throws<CardPairEmpty>(() => CardPair.Create("   ", ""));
        Assert.Throws<CardPairEmpty>(() => CardPair.Create("", "   "));
        Assert.Throws<CardPairEmpty>(() => CardPair.Create("", "reverse"));
        Assert.Throws<CardPairEmpty>(() => CardPair.Create("anverse", ""));
        Assert.DoesNotThrow(() => CardPair.Create("anverse", "reverse"));
    }

    [Test]
    public void Have_an_anverse_and_a_reverse_when_it_is_created()
    {
        var card = Card.Create(CardPair.Create("anverse", "reverse"));
        Assert.That(card.Pair.Anverse, Is.EqualTo("anverse"));
        Assert.That(card.Pair.Reverse, Is.EqualTo("reverse"));
    }
}