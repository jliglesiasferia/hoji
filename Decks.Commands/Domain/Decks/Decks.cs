namespace Decks.Commands.Domain;

public class Decks : EntityCollection<Deck>
{
    public static Decks Create()
    => new Decks();

    private Decks()
    : base()
    { }
}