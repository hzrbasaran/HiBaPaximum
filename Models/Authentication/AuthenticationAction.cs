using HiBaPaximum.Base;

namespace HiBaPaximum.Authentication;

public class AuthenticationAction
{
    public static async Task<BaseResponse<LoginResponse>> Login(LoginRequest model,ActionFields actionFields)
    {
        return await HibaPaximumHttpClient
            .Create()
            .ExecuteAsync<LoginRequest, BaseResponse<LoginResponse>>(model,actionFields);
    }
}