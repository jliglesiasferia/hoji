namespace Decks.Commands.Domain;

public class Card {
    public CardPair Pair { get; }

    public static Card Create(CardPair pair)
    => new Card(pair);

    private Card(CardPair pair)
    {
        Pair = pair;
    }
}