using System.Text.Json.Serialization;
using HiBaPaximum.Common;

namespace HiBaPaximum.Models.Hotel.Models;

public class OfferItem
{
    [JsonPropertyName("night")]public int Night { get; set; }
    [JsonPropertyName("isAvailable")]public bool IsAvailable { get; set; }
    [JsonPropertyName("availability")]public int Availability { get; set; }
    [JsonPropertyName("rooms")]public List<Room> Rooms { get; set; }
    [JsonPropertyName("isRefundable")]public bool IsRefundable { get; set; }
    [JsonPropertyName("cancellationPolicies")]public List<CancellationPolicy> CancellationPolicies { get; set; }
    [JsonPropertyName("priceBreakdowns")]public List<PriceBreakdowns> PriceBreakdowns { get; set; }
    [JsonPropertyName("thirdPartyOwnOffer")]public bool ThirdPartyOwnOffer { get; set; }
    [JsonPropertyName("restrictions")]public List<dynamic> Restrictions { get; set; }
    [JsonPropertyName("warnings")]public List<dynamic> Warnings { get; set; }
    [JsonPropertyName("expiresOn")]public DateTime ExpiresOn { get; set; }
    [JsonPropertyName("offerId")]public string OfferId { get; set; }
    [JsonPropertyName("checkIn")]public DateTime CheckIn { get; set; }
    [JsonPropertyName("price")]public PriceItem Price { get; set; }
}