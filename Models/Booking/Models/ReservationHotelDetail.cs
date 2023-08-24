using System.Text.Json.Serialization;
using HiBaPaximum.Common;
using HiBaPaximum.Models.Hotel.Models;

namespace HiBaPaximum.Models.Booking.Models;

public class ReservationHotelDetail:ListItemWithId
{
    [JsonPropertyName("address")]public HotelAddress Address { get; set; }
    [JsonPropertyName("phoneNumber")]public string PhoneNumber { get; set; }
    [JsonPropertyName("transferLocation")]public TransferLocation TransferLocation { get; set; }
    [JsonPropertyName("stopSaleGuaranteed")]public int StopSaleGuaranteed { get; set; }
    [JsonPropertyName("stopSaleStandart")]public int StopSaleStandart { get; set; }
    [JsonPropertyName("restrictions")]public List<dynamic> Restrictions { get; set; }
    [JsonPropertyName("handicaps")]public List<dynamic> Handicaps { get; set; }
    [JsonPropertyName("geolocation")]public GeoLocationItem Geolocation { get; set; }
    [JsonPropertyName("stars")]public double Stars { get; set; }
    [JsonPropertyName("location")]public TransferLocation Location { get; set; }
    [JsonPropertyName("country")]public TransferLocation Country { get; set; }
    [JsonPropertyName("city")]public TransferLocation City { get; set; }
    [JsonPropertyName("thumbnail")]public string Thumbnail { get; set; }
}