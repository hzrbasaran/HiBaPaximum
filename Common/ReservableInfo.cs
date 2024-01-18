using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class ReservableInfo
{
    [JsonPropertyName("bookingNumber")] public string BookingNumber { get; set; }
    [JsonPropertyName("encryptedBookingNumber")] public string EncryptedBookingNumber { get; set; }
    [JsonPropertyName("beginDate")] public DateTime BeginDate { get; set; }
    [JsonPropertyName("endDate")] public DateTime EndDate { get; set; }
    [JsonPropertyName("salePrice")] public PriceItem SalePrice { get; set; }
    [JsonPropertyName("totalPrice")] public PriceItem TotalPrice { get; set; }
    [JsonPropertyName("reservable")] public bool Reservable { get; set; }
    [JsonPropertyName("createDate")] public DateTime CreateDate { get; set; }
}