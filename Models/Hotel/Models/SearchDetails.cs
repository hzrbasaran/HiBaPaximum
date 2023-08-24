using System.Text.Json.Serialization;

namespace HiBaPaximum.Models.Hotel.Models;

public class SearchDetails
{
    [JsonPropertyName("enablePaging")]public bool EnablePaging { get; set; }
}