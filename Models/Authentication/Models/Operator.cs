using System.Text.Json.Serialization;
using HiBaPaximum.Common;

namespace HiBaPaximum.Authentication.Models;

public class Operator : ListItemWithCode
{
    [JsonPropertyName("thumbnail")]public string Thumbnail { get; set; }
    [JsonPropertyName("agencyCanDiscountCommission")]public bool AgencyCanDiscountCommission { get; set; }
}