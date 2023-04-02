using Base.Domain;

namespace Decks.Commands.Domain;

public class User
: Entity
{
    public static User Create()
    => new User();

    private User()
    { }
}