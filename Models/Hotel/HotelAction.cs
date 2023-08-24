using HiBaPaximum.Base;
using HiBaPaximum.Models.Hotel.Offer;
using HiBaPaximum.Models.Hotel.ProductInfo;
using HiBaPaximum.Models.Hotel.Search;

namespace HiBaPaximum.Models.Hotel;

public class HotelAction
{
    public static async Task<BaseResponse<PriceSearchResponse>> Search(PriceSearchRequest model, ActionFields actionFields)
    {
        return await HibaPaximumHttpClient
            .Create()
            .ExecuteAsync<PriceSearchRequest, BaseResponse<PriceSearchResponse>>(model,actionFields);
    }
    
    public static async Task<BaseResponse<ProductInfoResponse>> ProductInfo(ProductInfoRequest model, ActionFields actionFields)
    {
        return await HibaPaximumHttpClient
            .Create()
            .ExecuteAsync<ProductInfoRequest, BaseResponse<ProductInfoResponse>>(model,actionFields);
    }

    public static async Task<BaseResponse<GetOffersResponse>> GetOffers(GetOffersRequest model, ActionFields actionFields)
    {
        return await HibaPaximumHttpClient
            .Create()
            .ExecuteAsync<GetOffersRequest, BaseResponse<GetOffersResponse>>(model, actionFields);
    }
}
