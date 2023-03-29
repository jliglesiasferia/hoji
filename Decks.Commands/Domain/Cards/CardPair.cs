namespace Decks.Commands.Domain;

public class CardPair : ValueObject
{
    public string Anverse { get; }
    
    public string Reverse { get; }

    public static CardPair Create(string anverse, string reverse)
    => new CardPair(anverse, reverse);

    private CardPair(string anverse, string reverse)
    {
        Validate(anverse);
        Validate(reverse);
        
        Anverse = anverse;
        Reverse = reverse;
    }

    private void Validate(string value)
    {
        if (String.IsNullOrWhiteSpace(value))
        {
            throw new CardPairEmpty();
        }
    }
}