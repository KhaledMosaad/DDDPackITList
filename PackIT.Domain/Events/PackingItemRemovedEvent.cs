using PackIT.Domain.Entities;
using PackIT.Domain.ValueObjects;
using PackIT.SharedAbstractions.Domain;

namespace PackIT.Domain.Events;

public record PackingItemRemovedEvent(PackingList PackingList,PackingItem Item):IDomainEvent
{
}