using System.Text.Json.Serialization;
using HiBaPaximum.Models.Booking.Models;

namespace HiBaPaximum.Models.Booking.Transaction;

public class BeginTransactionResponse
{
    [JsonPropertyName("transactionId")] public Guid TransactionId { get; set; }
    [JsonPropertyName("expiresOn")] public DateTime ExpiresOn { get; set; }
    [JsonPropertyName("reservationData")] public ReservationData ReservationData { get; set; }
    [JsonPropertyName("status")] public int Status { get; set; }
    [JsonPropertyName("transactionType")] public int TransactionType { get; set; }
}