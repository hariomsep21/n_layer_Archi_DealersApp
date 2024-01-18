using DealerApp.Model;


namespace DealerApp.Service.Interface
{
    public interface IStockAuditService
    {
        Task<List<UpcomingAuditModel>> GetUpcomingAudit();
        Task<List<UpcomingAuditModel>> GetPendingAudit();

        Task<List<UpcomingAuditModel>> GetAuditStatus();
        Task<List<AddressDto>> GetAddress();

    }
}
