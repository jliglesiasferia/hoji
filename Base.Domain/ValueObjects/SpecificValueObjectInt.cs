namespace Base.Domain;

public abstract record ValueObjectInt(int Value)
: ValueObject<int>(Value)
{ }