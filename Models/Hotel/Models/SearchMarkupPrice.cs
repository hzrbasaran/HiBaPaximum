using System.Text.Json.Serialization;

namespace HiBaPaximum.Models.Hotel.Models;

public class SearchMarkupPrice
{
    [JsonPropertyName("currency")] public string Currency { get; set; }
    [JsonPropertyName("percent")] public int Percent { get; set; }
}