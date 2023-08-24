using System.Text.Json.Serialization;
using HiBaPaximum.Common;

namespace HiBaPaximum.Authentication.Models;

public class UserInfo : ListItemWithCode
{
    [JsonPropertyName("mainAgency")]public MainAgency MainAgency { get; set; }
    [JsonPropertyName("agency")]public Agency Agency { get; set; }
    [JsonPropertyName("office")]public ListItemWithCode Office { get; set; }
    [JsonPropertyName("operator")]public Operator Operator { get; set; }
    [JsonPropertyName("webSiteId")]public int WebSiteId { get; set; }
    [JsonPropertyName("marketWebSiteId")]public int MarketWebSiteId { get; set; }
    [JsonPropertyName("allowChangePassword")]public bool AllowChangePassword { get; set; }
    [JsonPropertyName("allowCreateNewUser")]public bool AllowCreateNewUser { get; set; }
    [JsonPropertyName("allowCreateAgency")]public bool AllowCreateAgency { get; set; }
    [JsonPropertyName("allowMakeReservation")]public bool AllowMakeReservation { get; set; }
    [JsonPropertyName("allowEditReservation")]public bool AllowEditReservation { get; set; }
    [JsonPropertyName("allowCancelReservation")]public bool AllowCancelReservation { get; set; }
    [JsonPropertyName("allowB2BUpdate")]public bool AllowB2BUpdate { get; set; }
    [JsonPropertyName("expireDate")]public DateTime ExpireDate { get; set; }
    [JsonPropertyName("mobile")]public string Mobile { get; set; }
    [JsonPropertyName("email")]public string Email { get; set; }
    [JsonPropertyName("passwordChangedDate")]public DateTime PasswordChangedDate { get; set; }
    [JsonPropertyName("allowApiAccess")]public bool AllowApiAccess { get; set; }
    [JsonPropertyName("lastAccessDate")]public DateTime LastAccessDate { get; set; }
}