using System.Text.Json.Serialization;
using HiBaPaximum.Base;
using HiBaPaximum.Enumarations;

namespace HiBaPaximum.Models.Hotel.ProductInfo;

public class ProductInfoRequest : BaseRequest
{
    public override string EndpointUrl => "/api/productService/getProductInfo";
    [JsonPropertyName("productType")] public ProductTypes ProductType { get; set; }
    [JsonPropertyName("ownerProvider")] public int OwnerProvider { get; set; }
    [JsonPropertyName("product")] public string Product { get; set; }
    [JsonPropertyName("culture")] public string Culture { get; set; }
}