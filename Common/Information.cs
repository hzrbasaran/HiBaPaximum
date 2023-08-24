using System.Text.Json.Serialization;

namespace HiBaPaximum.Common
{
    public class Information
    {
        [JsonPropertyName("total")] public int Total { get; set; }
    }
}
