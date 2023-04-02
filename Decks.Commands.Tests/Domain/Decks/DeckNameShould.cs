namespace Decks.Commands.Domain.Tests;

public class DeckNameShould
{
    [Test]
    public void Throw_an_exception_when_name_is_empty()
    {
        Assert.Throws<DeckNameEmpty>(() => DeckName.Create(""));
        Assert.Throws<DeckNameEmpty>(() => DeckName.Create("   "));
        Assert.DoesNotThrow(() => DeckName.Create("deck name"));
    }

    [Test]
    public void Have_the_name_assign_to_the_deck()
    {
        var deckName = DeckName.Create("deck name");
        Assert.That(deckName, Is.EqualTo("deck name"));
    }
}
