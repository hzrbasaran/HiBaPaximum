using System.Text.Json.Serialization;
using HiBaPaximum.Models.Hotel.Models;

namespace HiBaPaximum.Models.Hotel.ProductInfo;

public class ProductInfoResponse
{
    [JsonPropertyName("hotel")]public HotelDetail Hotel { get; set; }
}