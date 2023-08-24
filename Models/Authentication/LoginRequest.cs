using System.Text.Json.Serialization;
using HiBaPaximum.Base;

namespace HiBaPaximum.Authentication;

public class LoginRequest : BaseRequest
{
    public override string EndpointUrl => "/api/authenticationService/login";
    [JsonPropertyName("agency")]public string Agency { get; set; }
    [JsonPropertyName("user")]public string User { get; set; }
    [JsonPropertyName("Password")]public string Password { get; set; }
}