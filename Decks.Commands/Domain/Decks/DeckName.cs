namespace Decks.Commands.Domain;

public class DeckName
{
    public string Value { get; private set; }

    public static DeckName Create(string value)
    => new DeckName(value);

    private DeckName(string value)
    {
        Validate(value);
        Value = value;
    }

    private void Validate(string value)
    {
        if (String.IsNullOrWhiteSpace(value))
        {
            throw new DeckNameEmpty();
        }
    }
}