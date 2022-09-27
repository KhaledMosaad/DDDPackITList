using PackIT.Domain.Exceptions;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Entities;

public class PackingList
{
    public Guid Id { get; private set; }
    private PackingListName _name;
    private PackingListLocalization _localization;
    private readonly LinkedList<PackingItem> _packingItems=new();
    public PackingList(Guid id,PackingListName name,PackingListLocalization localization, LinkedList<PackingItem> packingItems)
    {
        Id = id;
        _name = name;
        _localization = localization;
    }

    public void AddItem(PackingItem item)
    {
        var alreadyExists = _packingItems.Any(it => it.Name == item.Name);
        if(alreadyExists)throw new PackingItemDuplicatedException(_name.Value,item.Name);
        _packingItems.AddLast(item);
    }
}