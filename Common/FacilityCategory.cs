using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class FacilityCategory
{
    [JsonPropertyName("name")]public string Name { get; set; }
    [JsonPropertyName("facilities")]public List<ListItemWithPrice> Facilities { get; set; }
}