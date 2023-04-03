using Base.Domain;

namespace Decks.Commands.Domain;

public class Deck
: Entity
{
    public EntityId UserId { get; }

    public DeckName Name { get; }

    public Cards Cards { get; }

    public static Deck Create(EntityId userId, DeckName name)
    => new Deck(userId, name);

    private Deck(EntityId userId, DeckName name)
    {
        UserId = userId;
        Name = name;
        Cards = Cards.Create();
    }

    public void AddCard(Card card)
    => Cards.Add(card);

    public void RemoveCard(Card card)
    => Cards.Remove(card);
}