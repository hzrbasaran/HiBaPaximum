using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class TravellerServiceItem
{
    [JsonPropertyName("id")] public string Id { get; set; }
    [JsonPropertyName("type")] public int Type { get; set; }
    [JsonPropertyName("price")] public PriceItem Price { get; set; }
    [JsonPropertyName("passengerType")] public int PassengerType { get; set; }
}