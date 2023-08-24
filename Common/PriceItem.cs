using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class PriceItem
{
    [JsonPropertyName("amount")]public double Amount { get; set; }
    [JsonPropertyName("currency")]public string Currency { get; set; }
}

public class PriceItemWithPercent : PriceItem
{
    [JsonPropertyName("percent")]public double Percent { get; set; }
}