using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class TravellerAddress
{
    [JsonPropertyName("contactPhone")] public Object ContactPhone { get; set; }
    [JsonPropertyName("email")] public string Email { get; set; }
    [JsonPropertyName("address")] public string Address { get; set; }
    [JsonPropertyName("zipCode")] public string ZipCode { get; set; }
    [JsonPropertyName("city")] public ListItemWithId City { get; set; }
    [JsonPropertyName("country")] public ListItemWithId Country { get; set; }
}