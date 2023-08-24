using System.Text.Json.Serialization;
using HiBaPaximum.Common;

namespace HiBaPaximum.Models.Booking.Models;

public class ReservationData
{
    [JsonPropertyName("travellers")] public List<TravellerItem> Travellers { get; set; }
    [JsonPropertyName("reservationInfo")] public ReservableInfo ReservationInfo { get; set; }
    [JsonPropertyName("services")] public List<ReservationService> Services { get; set; }
    [JsonPropertyName("paymentDetail")] public PaymentDetail PaymentDetail { get; set; }
    [JsonPropertyName("invoices")] public List<dynamic> Invoices { get; set; }
}