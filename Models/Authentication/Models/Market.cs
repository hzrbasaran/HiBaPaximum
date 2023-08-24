using System.Text.Json.Serialization;
using HiBaPaximum.Common;

namespace HiBaPaximum.Authentication.Models;

public class Market : ListItemWithCode
{
    [JsonPropertyName("favicon")]public string Favicon { get; set; }
    [JsonPropertyName("faviconPng")]public bool FaviconPng { get; set; }
}