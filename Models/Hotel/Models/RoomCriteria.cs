using System.Text.Json.Serialization;

namespace HiBaPaximum.Models.Hotel.Models;

public class RoomCriteria
{
    [JsonPropertyName("adult")] public int Adult { get; set; }
    [JsonPropertyName("childAges")] public List<int> ChildAges { get; set; }
}