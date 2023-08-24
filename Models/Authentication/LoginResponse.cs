using System.Text.Json.Serialization;
using HiBaPaximum.Authentication.Models;

namespace HiBaPaximum.Authentication;

public class LoginResponse
{
    [JsonPropertyName("token")]public string Token { get; set; }
    [JsonPropertyName("expiresOn")]public DateTime ExpiresOn { get; set; }
    [JsonPropertyName("tokenId")]public long TokenId { get; set; }
    [JsonPropertyName("userInfo")]public UserInfo UserInfo { get; set; }
    [JsonPropertyName("loggedInWithMasterKey")]public bool LoggedInWithMasterKey { get; set; }
}