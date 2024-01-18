using System.Text.Json.Serialization;
using HiBaPaximum.Models.Booking.Models;

namespace HiBaPaximum.Models.Booking.GetReservationDetail;


public class GetReservationDetailResponse
{
    [JsonPropertyName("reservationNumber")] public string ReservationNumber { get; set; }
    [JsonPropertyName("encryptedReservationNumber")] public string EncryptedReservationNumber { get; set; }
    [JsonPropertyName("transactionId")] public Guid TransactionId { get; set; }
    [JsonPropertyName("expiresOn")] public DateTime ExpiresOn { get; set; }
    [JsonPropertyName("reservationData")] public ReservationData ReservationData { get; set; }
    [JsonPropertyName("status")] public int Status { get; set; }
}