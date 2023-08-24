using System.Text.Json.Serialization;

namespace HiBaPaximum.Models.Hotel.Models;

public class HotelDescription
{
    [JsonPropertyName("text")]public string Text { get; set; }
}