using System.Text.Json.Serialization;
using HiBaPaximum.Common;

namespace HiBaPaximum.Models.Hotel.Models;

public class HotelDetail : Hotel
{
    [JsonPropertyName("seasons")]public List<HotelSeason> Seasons { get; set; }
    [JsonPropertyName("address")]public HotelAddress Address { get; set; }
    [JsonPropertyName("faxNumber")]public string FaxNumber { get; set; }
    [JsonPropertyName("phoneNumber")]public string PhoneNumber { get; set; }
    [JsonPropertyName("homePage")]public string HomePage { get; set; }
    [JsonPropertyName("stopSaleGuaranteed")]public int StopSaleGuaranteed { get; set; }
    [JsonPropertyName("stopSaleStandart")]public int StopSaleStandart { get; set; }
    [JsonPropertyName("handicaps")]public List<dynamic> Handicaps { get; set; }
    
}