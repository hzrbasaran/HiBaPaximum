using System.Text.Json.Serialization;
using HiBaPaximum.Common;
using HiBaPaximum.Enumarations;

namespace HiBaPaximum.Models.Booking.Models;

public class ReservationService : ListItemWithIdCode
{
    [JsonPropertyName("orderNumber")] public int OrderNumber { get; set; }
    [JsonPropertyName("note")] public string Note { get; set; }
    [JsonPropertyName("departureCountry")] public LocationCountry DepartureCountry { get; set; }
    [JsonPropertyName("departureCity")] public LocationCity DepartureCity { get; set; }
    [JsonPropertyName("arrivalCountry")] public LocationCountry ArrivalCountry { get; set; }
    [JsonPropertyName("arrivalCity")] public LocationCity ArrivalCity { get; set; }
    [JsonPropertyName("serviceDetails")] public ReservationServiceDetail ServiceDetails { get; set; }
    [JsonPropertyName("isMainService")] public bool IsMainService { get; set; }
    [JsonPropertyName("isRefundable")] public bool IsRefundable { get; set; }
    [JsonPropertyName("bundle")] public bool Bundle { get; set; }
    [JsonPropertyName("cancellationPolicies")]public List<CancellationPolicy> CancellationPolicies { get; set; }
    [JsonPropertyName("documents")]public List<dynamic> Documents { get; set; }
    [JsonPropertyName("encryptedServiceNumber")] public string EncryptedServiceNumber { get; set; }
    [JsonPropertyName("priceBreakDowns")]public List<dynamic> PriceBreakDowns { get; set; }
    [JsonPropertyName("commission")] public double Commission { get; set; }
    [JsonPropertyName("reservableInfo")] public ReservableInfo ReservableInfo { get; set; }
    [JsonPropertyName("unit")] public int Unit { get; set; }
    [JsonPropertyName("conditionalSpos")]public List<dynamic> ConditionalSpos { get; set; }
    [JsonPropertyName("isThirdPartyOwnProvider")] public bool IsThirdPartyOwnProvider { get; set; }
    [JsonPropertyName("isThirdPartyOwnOffer")] public bool IsThirdPartyOwnOffer { get; set; }
    [JsonPropertyName("thirdPartyInformation")] public ThirdPartyInformation ThirdPartyInformation { get; set; }
    [JsonPropertyName("confirmationStatus")] public ConfirmationStatus ConfirmationStatus { get; set; }
    [JsonPropertyName("serviceStatus")] public int ServiceStatus { get; set; }
    [JsonPropertyName("productType")] public ProductTypes ProductType { get; set; }
    [JsonPropertyName("beginDate")] public DateTime BeginDate { get; set; }
    [JsonPropertyName("endDate")] public DateTime EndDate { get; set; }
    [JsonPropertyName("adult")] public int Adult { get; set; }
    [JsonPropertyName("child")] public int Child { get; set; }
    [JsonPropertyName("infant")] public int Infant { get; set; }
    [JsonPropertyName("netPrice")] public PriceItem NetPrice { get; set; }
    [JsonPropertyName("price")] public PriceItem Price { get; set; }
    [JsonPropertyName("includePackage")] public bool IncludePackage { get; set; }
    [JsonPropertyName("compulsory")] public bool Compulsory { get; set; }
    [JsonPropertyName("isExtraService")] public bool IsExtraService { get; set; }
    [JsonPropertyName("supplierCode")] public string SupplierCode { get; set; }
    [JsonPropertyName("supplierName")] public string SupplierName { get; set; }
    [JsonPropertyName("supplier")] public string Supplier { get; set; }
    [JsonPropertyName("provider")] public int Provider { get; set; }
    [JsonPropertyName("travellers")] public List<string> Travellers { get; set; }
    [JsonPropertyName("thirdPartyRecord")] public bool ThirdPartyRecord { get; set; }
    [JsonPropertyName("recordId")] public int RecordId { get; set; }
    [JsonPropertyName("additionalFields")] public AdditionalFields AdditionalFields { get; set; }
    
}