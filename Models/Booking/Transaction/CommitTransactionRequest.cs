using System.Text.Json.Serialization;
using HiBaPaximum.Base;

namespace HiBaPaximum.Models.Booking.Transaction;

public class CommitTransactionRequest : BaseRequest
{
    public override string EndpointUrl => "/api/bookingService/commitTransaction";
    [JsonPropertyName("transactionId")] public Guid TransactionId { get; set; }
}