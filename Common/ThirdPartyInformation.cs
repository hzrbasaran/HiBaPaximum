using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class ThirdPartyInformation
{
    [JsonPropertyName("infos")]public List<dynamic> Infos { get; set; }
}