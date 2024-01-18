using DealerApp.Model;


namespace DealerApp.Service.Interface
{
    public interface IProfileInformationService
    {
        Task<ProfileInformationDTO> GetProfileInformationAsync();
    }
}
