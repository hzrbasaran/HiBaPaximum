using System.Text.Json.Serialization;
using HiBaPaximum.Common;

namespace HiBaPaximum.Models.Booking.Models;

public class ReservationServiceDetail
{
    [JsonPropertyName("serviceId")] public string ServiceId { get; set; }
    [JsonPropertyName("thumbnail")] public string Thumbnail { get; set; }
    [JsonPropertyName("hotelDetail")] public ReservationHotelDetail HotelDetail { get; set; }
    [JsonPropertyName("night")] public int Night { get; set; }
    [JsonPropertyName("roomCode")] public string RoomCode { get; set; }
    [JsonPropertyName("room")] public string Room { get; set; }
    [JsonPropertyName("boardCode")] public string BoardCode { get; set; }
    [JsonPropertyName("board")] public string Board { get; set; }
    [JsonPropertyName("accom")] public string Accom { get; set; }
    [JsonPropertyName("star")] public string Star { get; set; }
    [JsonPropertyName("geoLocation")] public GeoLocationItem GeoLocation { get; set; }
}