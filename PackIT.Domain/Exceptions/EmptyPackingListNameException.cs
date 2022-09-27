using PackIT.SharedAbstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class EmptyPackingListNameException:PackItException
{
    public EmptyPackingListNameException() : base("PACKING LIST NAME CAN NOT BE EMPTY!!!")
    {

    }
}