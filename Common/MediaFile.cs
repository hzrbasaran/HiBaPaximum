using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class MediaFile
{
    [JsonPropertyName("fileType")]public int FileType { get; set; }
    [JsonPropertyName("url")]public string Url { get; set; }
    [JsonPropertyName("urlFull")]public string UrlFull { get; set; }
}