using System.Text.Json.Serialization;
using HiBaPaximum.Common;

namespace HiBaPaximum.Base;

public class BaseResponseHeader
{
    [JsonPropertyName("requestId")] public Guid RequestId { get; set; }
    [JsonPropertyName("success")] public bool Success { get; set; }
    [JsonPropertyName("responseTime")] public DateTime ResponseTime { get; set; }
    [JsonPropertyName("messages")] public List<MessageItem> Messages { get; set; }
}
