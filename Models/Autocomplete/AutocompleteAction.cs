using HiBaPaximum.Base;

namespace HiBaPaximum.Models.Autocomplete;

public class AutocompleteAction
{
    public static async Task<BaseResponse<AutocompleteResponse>> Get(AutocompleteRequest model, ActionFields actionFields)
    {
        return await HibaPaximumHttpClient
            .Create()
            .ExecuteAsync<AutocompleteRequest, BaseResponse<AutocompleteResponse>>(model, actionFields);
    }
}