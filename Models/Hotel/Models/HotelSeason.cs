using System.Text.Json.Serialization;
using HiBaPaximum.Common;

namespace HiBaPaximum.Models.Hotel.Models;

public class HotelSeason
{
    [JsonPropertyName("name")]public string Name { get; set; }
    [JsonPropertyName("textCategories")]public List<TextCategory> TextCategories { get; set; }
    [JsonPropertyName("facilityCategories")]public List<FacilityCategory> FacilityCategories { get; set; }
    [JsonPropertyName("mediaFiles")]public List<MediaFile> MediaFiles { get; set; }
}