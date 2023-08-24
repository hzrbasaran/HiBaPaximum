using System.Text.Json.Serialization;
using HiBaPaximum.Common;
using HiBaPaximum.Enumarations;

namespace HiBaPaximum.Models.Autocomplete.Models;

public class AutocompleteResponseItem
{
    [JsonPropertyName("type")] public AutocompleteResponseTypes Type { get; set; }
    [JsonPropertyName("geolocation")] public GeoLocationItem GeoLocation { get; set; }
    [JsonPropertyName("country")] public ListItemWithId Country { get; set; }
    [JsonPropertyName("state")] public ListItemWithId State { get; set; }
    [JsonPropertyName("city")] public ListItemWithId City { get; set; }
    [JsonPropertyName("provider")] public int Provider { get; set; }
    [JsonPropertyName("hotelCount")] public int HotelCount { get; set; }
    [JsonPropertyName("hotel")] public ListItemHotel Hotel { get; set; }
}