using System.Text.Json.Serialization;
using HiBaPaximum.Models.Hotel.Models;

namespace HiBaPaximum.Models.Hotel.Search;

public class PriceSearchResponse
{
    [JsonPropertyName("searchId")] public Guid SearchId { get; set; }
    [JsonPropertyName("expiresOn")] public DateTime ExpiresOn { get; set; }
    [JsonPropertyName("hotels")] public List<Models.Hotel> Hotels { get; set; }
    [JsonPropertyName("details")] public SearchDetails Details { get; set; }
    
    public void SortOffersByPrice(bool isDescending=false)
    {
        foreach (var hotel in Hotels)
        {
            hotel.Offers = isDescending ? hotel.Offers.OrderByDescending(offer => offer.Price.Amount).ToList()
                :hotel.Offers.OrderBy(offer => offer.Price.Amount).ToList();
        }

        Hotels = isDescending
            ? Hotels.OrderByDescending(hotel => hotel.Offers.FirstOrDefault()?.Price.Amount ?? 0).ToList()
            : Hotels.OrderBy(hotel => hotel.Offers.FirstOrDefault()?.Price.Amount ?? 0).ToList();
    }
}