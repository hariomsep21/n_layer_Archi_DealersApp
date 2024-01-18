using DealerApp.Model;


namespace DealerApp.Service.Interface
{
    public interface IBasicDetailsService
    {
        Task<bool> PostUserDetails(BasicDetailsDTO userDetails);
        Task<List<DropDownStateDTO>> GetState();
    }
}
