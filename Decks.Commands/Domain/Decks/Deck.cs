namespace Decks.Commands.Domain;

public class Deck : Entity
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
}