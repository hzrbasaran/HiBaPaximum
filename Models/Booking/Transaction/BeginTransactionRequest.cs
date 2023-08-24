using System.Text.Json.Serialization;
using HiBaPaximum.Base;

namespace HiBaPaximum.Models.Booking.Transaction;

public class BeginTransactionRequest: BaseRequest
{
    public override string EndpointUrl => "/api/bookingService/beginTransaction";
    [JsonPropertyName("offerIds")] public List<string> OfferIdList { get; set; }
    [JsonPropertyName("currency")] public string Currency { get; set; }
    [JsonPropertyName("culture")] public string Culture { get; set; }
}