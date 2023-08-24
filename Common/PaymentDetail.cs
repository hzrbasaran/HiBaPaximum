using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class PaymentDetail
{
    [JsonPropertyName("paymentPlan")] public List<PriceItemWithPercent> PaymentPlan { get; set; }
    [JsonPropertyName("paymentInfo")] public List<dynamic> PaymentInfo { get; set; }
}