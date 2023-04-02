namespace Decks.Commands.Domain.Tests;

public class CardShould
{
    [Test]
    public void Have_an_anverse_and_a_reverse_when_it_is_created()
    {
        var card = Card.Create(CardPair.Create("anverse", "reverse"));
        Assert.That(card.Pair.Anverse, Is.EqualTo("anverse"));
        Assert.That(card.Pair.Reverse, Is.EqualTo("reverse"));
    }
}