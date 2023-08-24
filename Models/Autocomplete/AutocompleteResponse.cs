using System.Text.Json.Serialization;
using HiBaPaximum.Models.Autocomplete.Models;

namespace HiBaPaximum.Models.Autocomplete;

public class AutocompleteResponse
{
    [JsonPropertyName("items")]public List<AutocompleteResponseItem> Items { get; set; }
}