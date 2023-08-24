using System.Text.Json.Serialization;
using HiBaPaximum.Enumarations;

namespace HiBaPaximum.Models.Hotel.Models;

public class Traveller
{
    [JsonPropertyName("type")]public TravellerTypes Type { get; set; }
    [JsonPropertyName("age")]public int Age { get; set; }
    [JsonPropertyName("nationality")]public string Nationality { get; set; }
}