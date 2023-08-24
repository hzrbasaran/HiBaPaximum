using System.Text.Json.Serialization;

namespace HiBaPaximum.Models.Booking.Transaction;

public class CommitTransactionResponse
{
    [JsonPropertyName("reservationNumber")] public string ReservationNumber { get; set; }
    [JsonPropertyName("encryptedReservationNumber")] public string EncryptedReservationNumber { get; set; }
    [JsonPropertyName("transactionId")] public Guid TransactionId { get; set; }
}