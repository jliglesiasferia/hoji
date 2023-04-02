using Base.Domain;

namespace Decks.Commands.Domain;

public class Deck
: Entity
{
    public User User { get; }

    public DeckName Name { get; }

    public Cards Cards { get; }

    public static Deck Create(User user, DeckName name)
    => new Deck(user, name);

    private Deck(User user, DeckName name)
    {
        User = user;
        Name = name;
        Cards = Cards.Create();
    }

    public void AddCard(Card card)
    => Cards.Add(card);

    public void RemoveCard(Card card)
    => Cards.Remove(card);
}