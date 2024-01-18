using DealerApp.Model;

namespace DealerApp.Service.Interface
{
    public interface IPaymnetService
    {
        Task<List<PaymentDetailDto>> GetDuePayments();
        Task<List<PaymentDetailDto>> GetPaymentStatus();
        Task<List<PaymentDetailDto>> GetUpcomingPayment();
        Task<PaymentDetailDto> GetPaymentDetails(int paymentId);
        Task<string> PaymentProof(int Id, PaymentProofImgDTO paymentProof);
    }
}
