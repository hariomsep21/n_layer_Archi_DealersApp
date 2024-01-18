using DealerApp.Model;


namespace DealerApp.Service.Interface
{
    public interface IFullAggragatorService
    {
        
        Task<IEnumerable<Agg_DropDownMakeDTO>> GetMakeData();
        Task<IEnumerable<Agg_DropDownModelDTO>> GetModelData();
        Task<IEnumerable<Agg_DropDownVariantDTO>> GetVariantData();
        Task<IEnumerable<Agg_DropDownYORegisDTO>> GetYearOfRegData();
        Task<bool> PostAggragatorDetails(PV_AggregatorDTO  aggregatorDTO);
        Task<bool> PostNewCarDealerDetails(PV_NewCarDealerDTO NewCarDetails);
        Task<bool> PostOpenMarketDetails(PV_OpenMarketDTO  openMarketDTO);
        Task<IEnumerable<VehicleRecordsDto>> GetCarVehicleRecord();
 

    }
}
