using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class AdditionalFields
{
    [JsonPropertyName("smsLimit")] public string SmsLimit { get; set; }
    [JsonPropertyName("priceChanged")] public string PriceChanged { get; set; }
    [JsonPropertyName("allowSalePriceEdit")] public string AllowSalePriceEdit { get; set; }
    [JsonPropertyName("sendFlightSms")] public string SendFlightSms { get; set; }
    [JsonPropertyName("isRefundable")] public string IsRefundable { get; set; }
    [JsonPropertyName("reservableInfo")] public string ReservableInfo { get; set; }
    [JsonPropertyName("isEditable")] public string IsEditable { get; set; }
    [JsonPropertyName("travellerTypeOrder")] public string TravellerTypeOrder { get; set; }
    [JsonPropertyName("travellerUniqueID")] public string TravellerUniqueID { get; set; }
    [JsonPropertyName("tourVisio_TravellerId")] public string TourVisio_TravellerId { get; set; }
    [JsonPropertyName("paximum_TravellerId")] public string Paximum_TravellerId { get; set; }
    [JsonPropertyName("birthDateFrom")] public DateTime BirthDateFrom { get; set; }
    [JsonPropertyName("birthDateTo")] public DateTime BirthDateTo { get; set; }
}