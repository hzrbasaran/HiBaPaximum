using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class Nationality
{
    [JsonPropertyName("twoLetterCode")] public string TwoLetterCode { get; set; }
}