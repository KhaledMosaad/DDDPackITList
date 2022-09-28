using PackIT.SharedAbstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class PackingItemNotExistException:PackItException
{
    private readonly string _itemName;

    public PackingItemNotExistException(string itemName) : base($"ITEM {itemName} NOT EXIST ON ITEM LIST.")
    {
        _itemName = itemName;
    }
}