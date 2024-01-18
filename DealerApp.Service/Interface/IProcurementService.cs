using DealerApp.Model;


namespace DealerApp.Service.Interface
{
    public interface IProcurementService
    {
        Task<List<ProcurementFilterModel>> GetFilters();
        Task<List<ProcurementDetialModel>> GetAllProcurements();
        Task<List<ProcurementDetialModel>> GetFilterProcurement(int Id);
        Task<List<ProcurementClosedModel>> GetClosedProcurements();
        Task<List<ProcurmentInProcessModel>> GetInprocessProcurements();
    }
}
