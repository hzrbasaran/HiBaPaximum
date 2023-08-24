using HiBaPaximum.Enumarations;

public class EnumExtensions
{
    public static LocationTypes ToLocationType(AutocompleteResponseTypes type)
    {
        return type switch
        {
            AutocompleteResponseTypes.Country => LocationTypes.Country,
            AutocompleteResponseTypes.City => LocationTypes.City,
            AutocompleteResponseTypes.Town => LocationTypes.Town,
            AutocompleteResponseTypes.Village => LocationTypes.Village,
            AutocompleteResponseTypes.Airport => LocationTypes.Airport,
            _ => throw new NotSupportedException()
        };
    }

    public static AutocompleteResponseTypes ToAutocompleteResponseTypes(LocationTypes type)
    {
        return type switch
        {
            LocationTypes.Country=>AutocompleteResponseTypes.Country,
            LocationTypes.City=>AutocompleteResponseTypes.City,
            LocationTypes.Town=>AutocompleteResponseTypes.Town,
            LocationTypes.Village=>AutocompleteResponseTypes.Village,
            LocationTypes.Airport=>AutocompleteResponseTypes.Airport,
            _ => throw new NotSupportedException()
        };
    }
}