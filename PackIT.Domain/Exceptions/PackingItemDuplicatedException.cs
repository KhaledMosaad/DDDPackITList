using PackIT.SharedAbstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class PackingItemDuplicatedException:PackItException
{
    private readonly string _itemName;
    private readonly string _listName;

    public PackingItemDuplicatedException(string itemName,string listName) : 
        base($"PACKING ITEM {itemName} ALREADY EXIST IN THE PACKING LIST {listName}!!!!")
    {
        _itemName = itemName;
        _listName = listName;
    }
}