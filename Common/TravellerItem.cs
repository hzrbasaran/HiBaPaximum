using System.Text.Json.Serialization;
using HiBaPaximum.Enumarations;
using HiBaPaximum.Models.Hotel.Models;

namespace HiBaPaximum.Common;

public class TravellerItem
{
    [JsonPropertyName("travellerId")] public string TravellerId { get; set; }
    [JsonPropertyName("type")] public int Type { get; set; }
    [JsonPropertyName("title")] public TravellerTypes Title { get; set; }
    [JsonPropertyName("availableTitles")] public List<ListItemWithId> AvailableTitles { get; set; }
    [JsonPropertyName("availableAcademicTitles")] public List<ListItemWithId> AvailableAcademicTitles { get; set; }
    [JsonPropertyName("passengerType")] public PassengerTypes PassengerType { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; }
    [JsonPropertyName("surname")] public string Surname { get; set; }
    [JsonPropertyName("isLeader")] public bool IsLeader { get; set; }
    [JsonPropertyName("birthDate")] public DateTime BirthDate { get; set; }
    [JsonPropertyName("nationality")] public Nationality Nationality { get; set; }
    [JsonPropertyName("identityNumber")] public string IdentityNumber { get; set; }
    [JsonPropertyName("passportInfo")] public PassportInfo PassportInfo { get; set; }
    [JsonPropertyName("address")] public TravellerAddress Address { get; set; }
    [JsonPropertyName("destinationAddress")] public Object DestinationAddress { get; set; }
    [JsonPropertyName("services")] public  List<TravellerServiceItem> Services { get; set; }
    [JsonPropertyName("orderNumber")] public int OrderNumber { get; set; }
    [JsonPropertyName("birthDateFrom")] public DateTime BirthDateFrom { get; set; }
    [JsonPropertyName("birthDateTo")] public DateTime BirthDateTo { get; set; }
    [JsonPropertyName("requiredFields")] public  List<string> RequiredFields { get; set; }
    [JsonPropertyName("documents")] public  List<string> Documents { get; set; }
    [JsonPropertyName("additionalFields")] public AdditionalFields AdditionalFields { get; set; }
    [JsonPropertyName("insertFields")] public  List<string> InsertFields { get; set; }
    [JsonPropertyName("status")] public int Status { get; set; }
}