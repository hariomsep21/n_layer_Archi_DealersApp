using DealerApp.Model;


namespace DealerApp.Service.Interface
{
    public interface IPurchaseVehicleService
    {
        Task<List<PurchaseVehicleRecordModel>> GetVehicleRecord();
        Task<List<PurchaseVehicleDocModel>> GetVehicleRecordById(int Id);
    }
}
