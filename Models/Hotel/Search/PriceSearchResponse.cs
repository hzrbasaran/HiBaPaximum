using System.Text.Json.Serialization;
using HiBaPaximum.Models.Hotel.Models;

namespace HiBaPaximum.Models.Hotel.Search;

public class PriceSearchResponse
{
    [JsonPropertyName("searchId")] public Guid SearchId { get; set; }
    [JsonPropertyName("expiresOn")] public DateTime ExpiresOn { get; set; }
    [JsonPropertyName("hotels")] public List<Models.Hotel> Hotels { get; set; }
    [JsonPropertyName("details")] public SearchDetails Details { get; set; }
}