using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class PresentationItem
{
    [JsonPropertyName("textType")]public int TextType { get; set; }
    [JsonPropertyName("text")]public string Text { get; set; }
}