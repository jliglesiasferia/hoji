using Base.Domain;

namespace Decks.Commands.Domain;

public class Deck
: Entity
{
    public DeckName Name { get; }

    public Cards Cards { get; }

    public static Deck Create(DeckName name)
    => new Deck(name);

    private Deck(DeckName name)
    {
        Name = name;
        Cards = Cards.Create();
    }

    public void AddCard(Card card)
    => Cards.Add(card);

    public void RemoveCard(Card card)
    => Cards.Remove(card);
}