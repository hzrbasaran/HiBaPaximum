using System.Text.Json.Serialization;
using HiBaPaximum.Base;
using HiBaPaximum.Common;
using HiBaPaximum.Enumarations;
using HiBaPaximum.Models.Hotel.Models;

namespace HiBaPaximum.Models.Hotel.Search;

public class PriceSearchRequest : BaseRequest
{
    public override string EndpointUrl => "/api/productService/priceSearch";
    
    [JsonPropertyName("checkAllotment")] public bool CheckAllotment { get; set; }
    [JsonPropertyName("checkStopSale")] public bool CheckStopSale { get; set; }
    [JsonPropertyName("getOnlyDiscountedPrice")] public bool GetOnlyDiscountedPrice { get; set; }
    [JsonPropertyName("getOnlyBestOffers")] public bool GetOnlyBestOffers { get; set; }
    [JsonPropertyName("productType")] public ProductTypes ProductType { get; set; }
    /// <summary>
    /// Use only regional search
    /// </summary>
    [JsonPropertyName("arrivalLocations")] public List<ArrivalLocationItem> ArrivalLocations { get; set; }
    /// <summary>
    /// Use only hotels search, HotelId List
    /// </summary>
    [JsonPropertyName("products")] public List<string> Products { get; set; }
    [JsonPropertyName("roomCriteria")] public List<RoomCriteria> RoomCriteria { get; set; }
    [JsonPropertyName("nationality")] public string Nationality { get; set; }
    /// <summary>
    /// CheckIn value format => YYYY-MM-DD
    /// </summary>
    [JsonPropertyName("checkIn")] public string CheckIn { get; set; }
    [JsonPropertyName("night")] public int Night { get; set; }
    [JsonPropertyName("currency")] public string Currency { get; set; }
    [JsonPropertyName("culture")] public string Culture { get; set; }
    [JsonPropertyName("markupPrice")] public SearchMarkupPrice MarkupPrice { get; set; }
    
}
