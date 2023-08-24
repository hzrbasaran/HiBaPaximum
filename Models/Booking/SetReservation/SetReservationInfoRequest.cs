using System.Text.Json.Serialization;
using HiBaPaximum.Base;
using HiBaPaximum.Common;

namespace HiBaPaximum.Models.Booking.SetReservation;

public class SetReservationInfoRequest: BaseRequest
{
    public override string EndpointUrl => "/api/bookingService/setReservationInfo";
    [JsonPropertyName("transactionId")] public Guid TransactionId { get; set; }
    [JsonPropertyName("travellers")] public List<TravellerItem> Travellers { get; set; }
    [JsonPropertyName("reservationNote")] public string ReservationNote { get; set; }
    [JsonPropertyName("agencyReservationNumber")] public string AgencyReservationNumber { get; set; }
}