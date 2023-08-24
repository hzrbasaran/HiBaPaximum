using System.Text.Json.Serialization;
using HiBaPaximum.Common;

namespace HiBaPaximum.Models.Hotel.Models;

public class HotelCategory : ListItemWithCode
{
    [JsonPropertyName("id")] public string Id { get; set; }
}