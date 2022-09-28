using PackIT.SharedAbstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class EmptyPackingListIdException:PackItException
{
    public EmptyPackingListIdException() : base("PACKING LIST ID CAN NOT BE EMPTY")
    {
    }
}