namespace Decks.Commands.Domain;

public class DeckShould
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
        var deck = Deck.Create(DeckName.Create("deck name"));
        Assert.That(deck.Name, Is.EqualTo("deck name"));
    }

    [Test]
    public void Have_the_cards_added_to_the_deck()
    {
        var card1 = Card.Create(CardPair.Create("anverse1", "reverse1"));
        var card2 = Card.Create(CardPair.Create("anverse2", "reverse2"));
        var card3 = Card.Create(CardPair.Create("anverse3", "reverse3"));
        var deck = Deck.Create(DeckName.Create("deck name"));
        
        deck.AddCard(card1);
        Assert.That(deck.Cards, Has.Exactly(1).Items);

        deck.AddCard(card2);
        Assert.That(deck.Cards, Has.Exactly(2).Items);

        deck.AddCard(card3);
        Assert.That(deck.Cards, Has.Exactly(3).Items);
    }

    [Test]
    public void Not_have_any_card_when_all_cards_are_removed()
    {
        var card1 = Card.Create(CardPair.Create("anverse1", "reverse1"));
        var card2 = Card.Create(CardPair.Create("anverse2", "reverse2"));
        var card3 = Card.Create(CardPair.Create("anverse3", "reverse3"));
        var deck = Deck.Create(DeckName.Create("deck name"));
        deck.AddCard(card1);
        deck.AddCard(card2);
        deck.AddCard(card3);

        Assert.That(deck.Cards, Has.Exactly(3).Items);

        deck.RemoveCard(card1);
        Assert.That(deck.Cards, Has.Exactly(2).Items);

        deck.RemoveCard(card2);
        Assert.That(deck.Cards, Has.Exactly(1).Items);

        deck.RemoveCard(card3);
        Assert.That(deck.Cards, Has.Exactly(0).Items);
    }
}