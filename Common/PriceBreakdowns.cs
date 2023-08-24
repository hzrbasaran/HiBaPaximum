using HiBaPaximum.Enumarations;
using System.Text.Json.Serialization;

namespace HiBaPaximum.Common
{
    public class PriceBreakdowns
    {
        [JsonPropertyName("productType")] public ProductTypes ProductType { get; set; }
        [JsonPropertyName("priceBreakdowns")] public List<PriceBreakdownItem> PriceBreakdownList { get; set; }
    }
}
