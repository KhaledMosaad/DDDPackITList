using PackIT.SharedAbstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class EmptyPackingItemNameException:PackItException
{
    public EmptyPackingItemNameException() : base("PACKING ITEM NAME CANNOT BE NULL OR EMPTY !!!")
    {
    }
}