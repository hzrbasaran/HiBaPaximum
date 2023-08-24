using System.Text.Json.Serialization;
using HiBaPaximum.Common;
using HiBaPaximum.Enumarations;

namespace HiBaPaximum.Models.Booking.Models;

public class ReservationInfo
{
    [JsonPropertyName("bookingNumber")] public string BookingNumber { get; set; }
    [JsonPropertyName("market")] public ListItemOnlyCode Market { get; set; }
    [JsonPropertyName("operator")] public ListItemOnlyCode Operator { get; set; }
    //Agency
    //AgencyUser
    [JsonPropertyName("beginDate")] public DateTime BeginDate { get; set; }
    [JsonPropertyName("endDate")] public DateTime EndDate { get; set; }
    [JsonPropertyName("note")] public string Note { get; set; }
    [JsonPropertyName("salePrice")] public PriceItem SalePrice { get; set; }
    [JsonPropertyName("supplementDiscount")] public PriceItem SupplementDiscount { get; set; }
    [JsonPropertyName("passengerEB")] public PriceItem PassengerEB { get; set; }
    [JsonPropertyName("agencyEB")] public PriceItem AgencyEB { get; set; }
    [JsonPropertyName("passengerAmountToPay")] public PriceItem PassengerAmountToPay { get; set; }
    [JsonPropertyName("agencyAmountToPay")] public PriceItem AgencyAmountToPay { get; set; }
    [JsonPropertyName("discount")] public PriceItem Discount { get; set; }
    [JsonPropertyName("agencyBalance")] public PriceItem AgencyBalance { get; set; }
    [JsonPropertyName("passengerBalance")] public PriceItem PassengerBalance { get; set; }
    [JsonPropertyName("agencyCommission")] public PriceItemWithPercent AgencyCommission { get; set; }
    [JsonPropertyName("brokerCommission")] public PriceItemWithPercent BrokerCommission { get; set; }
    [JsonPropertyName("agencySupplementCommission")] public PriceItemWithPercent AgencySupplementCommission { get; set; }
    [JsonPropertyName("promotionAmount")] public PriceItem PromotionAmount { get; set; }
    [JsonPropertyName("priceToPay")] public PriceItem PriceToPay { get; set; }
    [JsonPropertyName("agencyPriceToPay")] public PriceItem AgencyPriceToPay { get; set; }
    [JsonPropertyName("passengerPriceToPay")] public PriceItem PassengerPriceToPay { get; set; }
    [JsonPropertyName("totalPrice")] public PriceItem TotalPrice { get; set; }
    [JsonPropertyName("reservationStatus")] public ReservationStatus ReservationStatus { get; set; }
    [JsonPropertyName("confirmationStatus")] public ConfirmationStatus ConfirmationStatus { get; set; }
    [JsonPropertyName("paymentStatus")] public PaymentStatus PaymentStatus { get; set; }
    [JsonPropertyName("documents")] public List<dynamic> Documents { get; set; }
    [JsonPropertyName("otherDocuments")] public List<dynamic> OtherDocuments { get; set; }
    [JsonPropertyName("reservableInfo")] public ReservableInfo ReservableInfo { get; set; }
    [JsonPropertyName("paymentFrom")] public int PaymentFrom { get; set; }
    [JsonPropertyName("departureCountry")] public TransferLocation DepartureCountry { get; set; }
    [JsonPropertyName("departureCity")] public TransferLocation DepartureCity { get; set; }
    [JsonPropertyName("arrivalCountry")] public TransferLocation ArrivalCountry { get; set; }
    [JsonPropertyName("arrivalCity")] public TransferLocation ArrivalCity { get; set; }
    [JsonPropertyName("createDate")] public DateTime CreateDate { get; set; }
    [JsonPropertyName("changeDate")] public DateTime ChangeDate { get; set; }
    [JsonPropertyName("additionalFields")] public AdditionalFields AdditionalFields { get; set; }
    [JsonPropertyName("additionalCode1")] public string AdditionalCode1 { get; set; }
    [JsonPropertyName("additionalCode2")] public string AdditionalCode2 { get; set; }
    [JsonPropertyName("additionalCode3")] public string AdditionalCode3 { get; set; }
    [JsonPropertyName("additionalCode4")] public string AdditionalCode4 { get; set; }
    [JsonPropertyName("agencyDiscount")] public double AgencyDiscount { get; set; }
    [JsonPropertyName("hasAvailablePromotionCode")] public bool HasAvailablePromotionCode { get; set; }
    
    
}