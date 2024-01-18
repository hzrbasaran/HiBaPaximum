using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class TravellerAddress
{
    [JsonPropertyName("contactPhone")] public TravellerContactPhone ContactPhone { get; set; }
    [JsonPropertyName("phone")] public string Phone { get; set; }
    [JsonPropertyName("email")] public string Email { get; set; }
    [JsonPropertyName("address")] public string Address { get; set; }
    [JsonPropertyName("zipCode")] public string ZipCode { get; set; }
    [JsonPropertyName("city")] public ListItemWithId City { get; set; }
    [JsonPropertyName("country")] public ListItemWithId Country { get; set; }
}

public class TravellerContactPhone
{
    [JsonPropertyName("countryCode")] public string CountryCode { get; set; }
    [JsonPropertyName("areaCode")] public string AreaCode { get; set; }
    [JsonPropertyName("phoneNumber")] public string PhoneNumber { get; set; }
}