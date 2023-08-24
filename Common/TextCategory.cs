using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class TextCategory
{
    [JsonPropertyName("name")]public string Name { get; set; }
    [JsonPropertyName("presentations")]public List<PresentationItem> Presentations { get; set; }
}