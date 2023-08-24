using System.Text.Json.Serialization;

namespace HiBaPaximum.Common;

public class PassportInfo
{
    [JsonPropertyName("expireDate")] public DateTime ExpireDate { get; set; }
    [JsonPropertyName("issueDate")] public DateTime IssueDate { get; set; }
    [JsonPropertyName("citizenshipCountryCode")] public string CitizenshipCountryCode { get; set; }
}