using System.Text.Json.Serialization;

namespace HiBaPaximum.Authentication.Models;

public class Agency : AgencyBase
{
    [JsonPropertyName("id")]public string Id { get; set; }
    [JsonPropertyName("code")]public string Code { get; set; }
    [JsonPropertyName("name")]public string Name { get; set; }
    [JsonPropertyName("registerCode")]public string RegisterCode { get; set; }
    [JsonPropertyName("firmName")]public string FirmName { get; set; }
    [JsonPropertyName("licenseNo")]public string LicenseNo { get; set; }
    [JsonPropertyName("paymentFrom")]public int PaymentFrom { get; set; }
    [JsonPropertyName("qcPcc")]public string QcPcc { get; set; }
    [JsonPropertyName("qIdentNo")]public string QIdentNo { get; set; }
    [JsonPropertyName("nationality")]public string Nationality { get; set; }
    [JsonPropertyName("webSetGrp")]public string WebSetGrp { get; set; }
}
