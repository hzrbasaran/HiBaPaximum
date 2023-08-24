using System.Text.Json.Serialization;

namespace HiBaPaximum.Common
{
    public class PriceBreakdownItem
    {
        [JsonPropertyName("roomNumber")] public string RoomNumber { get; set; }
        [JsonPropertyName("date")] public DateTime Date { get; set; }
        [JsonPropertyName("price")] public PriceItem Price { get; set; }
    }
}
