using PackIT.Domain.Events;
using PackIT.Domain.Exceptions;
using PackIT.Domain.ValueObjects;
using PackIT.SharedAbstractions.Domain;

namespace PackIT.Domain.Entities;

public class PackingList:AggregateRoot<PackingListId>
{
    public PackingListId Id { get; private set; }
    private PackingListName _name;
    private PackingListLocalization _localization;
    private readonly LinkedList<PackingItem> _packingItems=new();
    private PackingList(PackingListId id,PackingListName name,PackingListLocalization localization, LinkedList<PackingItem> packingItems)
        :this(id,name,localization)
    {
        _packingItems = packingItems;
    }
    internal PackingList(PackingListId id,PackingListName name,PackingListLocalization localization)
    {
        Id = id;
        _name = name;
        _localization = localization;
    }

    public void AddItem(PackingItem item)
    {
        var alreadyExists = _packingItems.Any(it => it.Name == item.Name);
        if(alreadyExists)  throw new PackingItemDuplicatedException(_name.Value,item.Name);
        _packingItems.AddLast(item);
        AddEvent(new PackingItemAddEvent(this,item));
    }

    public void AddItems(IEnumerable<PackingItem> items)
    {
        foreach (var item in items)
        {
            AddItem(item);
        }
    }

    public void PackItem(string itemName)
    {
        var item = GetItem(itemName);
        var packedItem = item with { IsPacked = true };
        _packingItems.Find(item)!.Value = packedItem;
        AddEvent(new PackingItemAddEvent(this,item));
    }

    public void RemoveItem(string itemName)
    {
        var item = GetItem(itemName);
        _packingItems.Remove(item);
        AddEvent(new PackingItemRemovedEvent(this,item));
    }
    private PackingItem GetItem(string itemName)
    {
        var item = _packingItems.FirstOrDefault(i => i.Name == itemName);
        if (item is null)
        {
            throw new PackingItemNotExistException(itemName);
        }

        return item;
    }
}