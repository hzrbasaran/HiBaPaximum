using System.Text.Json.Serialization;
using HiBaPaximum.Common;

namespace HiBaPaximum.Models.Hotel.Models;

public class HotelAddress
{
    [JsonPropertyName("city")]public LocationItem City { get; set; }
    [JsonPropertyName("addressLines")]public List<string> AddressLines { get; set; }
    [JsonPropertyName("street")]public string Street { get; set; }
    [JsonPropertyName("streetNumber")]public string StreetNumber { get; set; }
    [JsonPropertyName("geolocation")]public GeoLocationItem Geolocation { get; set; }
}