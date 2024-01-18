using HiBaPaximum.Base;
using HiBaPaximum.Models.Booking.GetReservationDetail;
using HiBaPaximum.Models.Booking.SetReservation;
using HiBaPaximum.Models.Booking.Transaction;

namespace HiBaPaximum.Models.Booking;

public class BookingAction
{
    public static async Task<BaseResponse<BeginTransactionResponse>> BeginTransaction(BeginTransactionRequest model, ActionFields actionFields)
    {
        return await HibaPaximumHttpClient
            .Create()
            .ExecuteAsync<BeginTransactionRequest, BaseResponse<BeginTransactionResponse>>(model, actionFields);
    }

    public static async Task<BaseResponse<SetReservationInfoResponse>> SetReservationInfo(SetReservationInfoRequest model, ActionFields actionFields)
    {
        return await HibaPaximumHttpClient
            .Create()
            .ExecuteAsync<SetReservationInfoRequest, BaseResponse<SetReservationInfoResponse>>(model, actionFields);
    }

    public static async Task<BaseResponse<CommitTransactionResponse>> CommitTransaction(CommitTransactionRequest model, ActionFields actionFields)
    {
        return await HibaPaximumHttpClient
            .Create()
            .ExecuteAsync<CommitTransactionRequest, BaseResponse<CommitTransactionResponse>>(model, actionFields);
    }
    
    public static async Task<BaseResponse<GetReservationDetailResponse>> GetReservationDetail(GetReservationDetailRequest model, ActionFields actionFields)
    {
        return await HibaPaximumHttpClient
            .Create()
            .ExecuteAsync<GetReservationDetailRequest, BaseResponse<GetReservationDetailResponse>>(model, actionFields);
    }
}