using System.Text.Json.Serialization;

namespace HiBaPaximum.Base;

public class BaseResponse<T>
{
    [JsonPropertyName("header")] public BaseResponseHeader Header { get; set; } = null!;
    [JsonPropertyName("body")] public T Body { get; set; }
}