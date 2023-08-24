using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class CancellationPolicy
{
    [JsonPropertyName("roomNumber")]public string RoomNumber { get; set; }
    [JsonPropertyName("dueDate")]public DateTime DueDate { get; set; }
    [JsonPropertyName("price")]public PriceItem Price { get; set; }
    [JsonPropertyName("provider")]public int Provider { get; set; }
}