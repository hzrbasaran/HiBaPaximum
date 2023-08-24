using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class MessageItem
{
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("code")] public string Code { get; set; }
    [JsonPropertyName("messageType")] public int MessageType { get; set; }
    [JsonPropertyName("message")] public string Message { get; set; }
}