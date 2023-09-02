using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class ListItem
{
    [JsonPropertyName("name")] public string Name { get; set; } = null!;
}

public class ListItemWithCode : ListItem
{
    [JsonPropertyName("code")] public string Code { get; set; } = null!;
}

public class ListItemWithId : ListItem
{
    [JsonPropertyName("id")] public string Id { get; set; } = null!;
    public string Url {
        get
        {
            return Name.ToUrl();
        }
    }
}

public class ListItemWithIdCode : ListItem
{
    [JsonPropertyName("id")] public string Id { get; set; } = null!;
    [JsonPropertyName("code")] public string Code { get; set; } = null!;
}

public class ListItemOnlyId
{
    [JsonPropertyName("id")] public string Id { get; set; } = null!;
}
public class ListItemOnlyCode
{
    [JsonPropertyName("code")] public string Code { get; set; } = null!;
}

public class ListItemHotel : ListItemWithId
{
    [JsonPropertyName("internationalName")] public string InternationalName { get; set; } = null!;
}

public class ListItemWithPrice: ListItemWithId
{
    [JsonPropertyName("isPriced")]
    public bool IsPriced { get; set; }
}



public class ArrivalLocationItem
{
    [JsonPropertyName("id")] public string Id { get; set; }
    [JsonPropertyName("type")] public int Type { get; set; }
}
