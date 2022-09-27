namespace PackIT.Domain.ValueObjects;

public record PackingListLocalization(string City,string Country)
{
    public static PackingListLocalization Create(string value)
    {
        var splitLocalization = value.Split(',');
        return new(splitLocalization.First(), splitLocalization.Last());
    }

    public override string ToString() => $"{City},{Country}";
}