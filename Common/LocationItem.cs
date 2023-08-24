using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class LocationItem
{
    [JsonPropertyName("name")] public string Name { get; set; }
    [JsonPropertyName("countryId")] public string CountryId { get; set; }
    [JsonPropertyName("provider")] public int Provider { get; set; }
    [JsonPropertyName("isTopRegion")] public bool IsTopRegion { get; set; }
    [JsonPropertyName("id")] public string Id { get; set; }
    [JsonPropertyName("internationalCode")] public string InternationalCode { get; set; }
}

public class LocationCountry : LocationItem
{
    [JsonPropertyName("code")] public string Code { get; set; }
    [JsonPropertyName("type")] public int Type { get; set; }
    [JsonPropertyName("parentId")] public string ParentId { get; set; }
}

public class LocationCity : LocationItem
{
    [JsonPropertyName("type")] public int Type { get; set; }
}

public class TransferLocation : LocationCountry
{
    [JsonPropertyName("latitude")] public double Latitude { get; set; }
    [JsonPropertyName("longitude")] public double Longitude { get; set; }
}