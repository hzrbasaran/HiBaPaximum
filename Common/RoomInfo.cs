using System.Text.Json.Serialization;

namespace HiBaPaximum.Common
{
    public class RoomInfo
    {
        [JsonPropertyName("roomSize")] public string RoomSize { get; set; }
        [JsonPropertyName("bedOptions")] public List<string> BedOptions { get; set; }
        [JsonPropertyName("presentations")] public List<PresentationItem> Presentations { get; set; }
        [JsonPropertyName("mediaFiles")] public List<MediaFile> MediaFiles { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("id")] public string Id { get; set; }
    }
}
