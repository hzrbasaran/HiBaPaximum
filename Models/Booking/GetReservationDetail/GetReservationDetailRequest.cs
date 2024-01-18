using System.Text.Json.Serialization;
using HiBaPaximum.Base;

namespace HiBaPaximum.Models.Booking.GetReservationDetail;

public class GetReservationDetailRequest : BaseRequest
{
    public override string EndpointUrl => "/api/bookingService/getReservationDetail";
    [JsonPropertyName("reservationNumber")] public string ReservationNumber { get; set; }
}
