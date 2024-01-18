using DealerApp.Model;


namespace DealerApp.Service.Interface
{
   public interface IAccountInfoService
    {
        Task<AccountInfoDTO> GetAccountInfoDetails();
    }
}
