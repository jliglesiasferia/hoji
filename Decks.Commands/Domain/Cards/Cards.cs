namespace Decks.Commands.Domain;

public class Cards : EntityCollection<Card>
{
    public static Cards Create()
    => new Cards();

    private Cards()
    : base()
    { }
}