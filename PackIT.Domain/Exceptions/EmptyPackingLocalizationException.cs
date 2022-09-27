using PackIT.SharedAbstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class EmptyPackingLocalizationException:PackItException
{
    public EmptyPackingLocalizationException() : base("LOCALIZATION CAN NOT BE NULL OR EMPTY")
    {
    }
}