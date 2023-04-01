namespace Base.Domain;

public abstract record ValueObjectString(string Value)
: ValueObject<string>(Value)
{ }