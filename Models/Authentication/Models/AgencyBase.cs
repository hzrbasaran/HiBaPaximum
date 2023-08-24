using System.Text.Json.Serialization;

namespace HiBaPaximum.Authentication.Models;

public class AgencyBase
{
    [JsonPropertyName("ownAgency")]public bool OwnAgency { get; set; }
    [JsonPropertyName("useOwnWebSettings")]public bool UseOwnWebSettings { get; set; }
    [JsonPropertyName("sendFlightInfoSms")]public bool SendFlightInfoSms { get; set; }
    [JsonPropertyName("allowUnpaidRes")]public int AllowUnpaidRes { get; set; }
    [JsonPropertyName("aceExport")]public bool AceExport { get; set; }
    [JsonPropertyName("allowNon3DPayments")]public bool AllowNon3DPayments { get; set; }
    [JsonPropertyName("bonusUseSysParam")]public bool BonusUseSysParam { get; set; }
    [JsonPropertyName("bonusUserSeeAgencyW")]public bool BonusUserSeeAgencyW { get; set; }
    [JsonPropertyName("bonusUserSeeOwnW")]public bool BonusUserSeeOwnW { get; set; }
    [JsonPropertyName("allowAddCredit")]public bool AllowAddCredit { get; set; }
    [JsonPropertyName("showAgencyLogoOnB2b")]public bool ShowAgencyLogoOnB2b { get; set; }
    [JsonPropertyName("hideInstallmentTable")]public bool HideInstallmentTable { get; set; }
    [JsonPropertyName("hideAgencyCreditOnWeb")]public bool HideAgencyCreditOnWeb { get; set; }
    [JsonPropertyName("force2FactorAuth")]public bool Force2FactorAuth { get; set; }
    [JsonPropertyName("location")]public int Location { get; set; }
}