using System.Text.Json.Serialization;
using HiBaPaximum.Common;

namespace HiBaPaximum.Models.Hotel.Models;

public class Hotel : ListItemWithId
{
    [JsonPropertyName("geolocation")]public GeoLocationItem GeoLocation { get; set; }
    [JsonPropertyName("stars")]public double Stars { get; set; }
    [JsonPropertyName("rating")]public double Rating { get; set; }
    [JsonPropertyName("themes")]public List<ListItemWithId> Themes { get; set; }
    [JsonPropertyName("facilities")]public List<ListItemWithPrice> Facilities { get; set; }
    [JsonPropertyName("location")]public LocationItem Location { get; set; }
    [JsonPropertyName("country")]public LocationItem Country { get; set; }
    [JsonPropertyName("city")]public LocationItem City { get; set; }
    [JsonPropertyName("giataInfo")]public GiataInfo GiataInfo { get; set; }
    [JsonPropertyName("offers")]public List<OfferItem> Offers { get; set; }
    [JsonPropertyName("boardGroups")]public List<ListItemWithId> BoardGroups { get; set; }
    [JsonPropertyName("boards")]public List<ListItemOnlyId> Boards { get; set; }
    [JsonPropertyName("badges")]public List<ListItemWithId> Badges { get; set; }
    [JsonPropertyName("hotelCategory")]public HotelCategory HotelCategory { get; set; }
    [JsonPropertyName("hasThirdPartyOwnOffer")]public bool HasThirdPartyOwnOffer { get; set; }
    [JsonPropertyName("thirdPartyInformation")]public ThirdPartyInformation thirdPartyInformation { get; set; }
    [JsonPropertyName("productGroups")]public List<ListItemWithId> ProductGroups { get; set; }
    
    [JsonPropertyName("provider")]public int Provider { get; set; }
    [JsonPropertyName("thumbnail")]public string Thumbnail { get; set; }
    [JsonPropertyName("thumbnailFull")]public string ThumbnailFull { get; set; }
    [JsonPropertyName("description")]public HotelDescription HotelDescription { get; set; }
    
    public string Url => "/" + City.Name.ToUrl() + "-otelleri/" + Name.ToUrl();
}