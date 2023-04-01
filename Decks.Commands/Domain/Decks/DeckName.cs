using Base.Domain;

namespace Decks.Commands.Domain;

public record DeckName
: ValueObjectString
{
    public static DeckName Create(string value)
    => new DeckName(value);

    private DeckName(string value)
    : base(value)
    {
        Validate(value);
    }

    private void Validate(string value)
    {
        if (String.IsNullOrWhiteSpace(value))
        {
            throw new DeckNameEmpty();
        }
    }
}