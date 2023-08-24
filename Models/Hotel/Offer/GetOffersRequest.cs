using HiBaPaximum.Base;
using HiBaPaximum.Enumarations;
using System.Text.Json.Serialization;

namespace HiBaPaximum.Models.Hotel.Offer
{
    public class GetOffersRequest : BaseRequest
    {
        public override string EndpointUrl => "/api/productService/getOffers";
        [JsonPropertyName("searchId")] public string SearchId { get; set; }
        [JsonPropertyName("offerId")] public string OfferId { get; set; }
        [JsonPropertyName("productType")] public ProductTypes ProductType { get; set; }
        [JsonPropertyName("productId")] public string ProductId { get; set; }
        [JsonPropertyName("getroomInfo")] public bool GetRoomInfo { get; set; }
        [JsonPropertyName("currency")] public string Currency { get; set; }
        [JsonPropertyName("culture")] public string Culture { get; set; }
    }
}
