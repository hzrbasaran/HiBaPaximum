using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class GeoLocationItem
{
    [JsonPropertyName("longitude")] public double Longitude { get; set; }
    [JsonPropertyName("latitude")] public double Latitude { get; set; }
}