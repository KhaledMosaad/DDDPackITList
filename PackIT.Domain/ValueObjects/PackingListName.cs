using PackIT.Domain.Exceptions;

namespace PackIT.Domain.ValueObjects;

public record PackingListName
{
    public string Value { get; } // immutable object

    public PackingListName(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new EmptyPackingListNameException();
        }
        Value = value;
    }

    public static implicit operator PackingListName(string name) => new(name);
    public static implicit operator string(PackingListName name) => name.Value;
}