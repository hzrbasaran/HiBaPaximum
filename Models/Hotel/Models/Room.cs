using System.Text.Json.Serialization;
using HiBaPaximum.Common;

namespace HiBaPaximum.Models.Hotel.Models;

public class Room
{
    [JsonPropertyName("roomId")]public string RoomId { get; set; }
    [JsonPropertyName("roomName")]public string RoomName { get; set; }
    [JsonPropertyName("boardId")]public string BoardId { get; set; }
    [JsonPropertyName("boardName")]public string BoardName { get; set; }
    [JsonPropertyName("boardGroups")]public List<ListItemWithId> BoardGroups { get; set; }
    [JsonPropertyName("stopSaleGuaranteed")]public int StopSaleGuaranteed { get; set; }
    [JsonPropertyName("stopSaleStandart")]public int StopSaleStandart { get; set; }
    [JsonPropertyName("travellers")]public List<Traveller> Travellers { get; set; }
    [JsonPropertyName("roomInfoId")] public string RoomInfoId { get; set; }
    [JsonPropertyName("thirdPartyInformation")]public ThirdPartyInformation ThirdPartyInformation { get; set; }
    [JsonPropertyName("visiblePL")]public bool VisiblePL { get; set; }
}