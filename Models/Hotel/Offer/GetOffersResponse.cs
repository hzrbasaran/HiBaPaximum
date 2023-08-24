using HiBaPaximum.Common;
using HiBaPaximum.Models.Hotel.Models;
using System.Text.Json.Serialization;

namespace HiBaPaximum.Models.Hotel.Offer
{
    public class GetOffersResponse
    {
        [JsonPropertyName("offers")] public List<OfferItem> Offers { get; set; }
        [JsonPropertyName("information")] public Information Information { get; set; }
        [JsonPropertyName("roomInfos")] public List<RoomInfo> RoomInfos { get; set; }
    }
}
