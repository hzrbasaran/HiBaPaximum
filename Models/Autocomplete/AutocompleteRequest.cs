using System.Text.Json.Serialization;
using HiBaPaximum.Base;
using HiBaPaximum.Enumarations;

namespace HiBaPaximum.Models.Autocomplete;

public class AutocompleteRequest : BaseRequest
{
    public override string EndpointUrl => "/api/productService/getArrivalAutocomplete";
    [JsonPropertyName("productType")] public ProductTypes ProductType { get; set; }
    [JsonPropertyName("query")] public string Query { get; set; }
    [JsonPropertyName("culture")] public string Culture { get; set; }
    
}