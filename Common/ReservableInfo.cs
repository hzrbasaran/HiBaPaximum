using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class ReservableInfo
{
    [JsonPropertyName("reservable")] public bool Reservable { get; set; }
}