using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class GiataInfo
{
    [JsonPropertyName("hotelId")] public string HotelId { get; set; }
    [JsonPropertyName("destinationId")] public string DestinationId { get; set; }
}