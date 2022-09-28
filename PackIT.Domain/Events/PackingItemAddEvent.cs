using PackIT.Domain.Entities;
using PackIT.Domain.ValueObjects;
using PackIT.SharedAbstractions.Domain;

namespace PackIT.Domain.Events;

public record PackingItemAddEvent(PackingList PackingList,PackingItem Item):IDomainEvent
{
}