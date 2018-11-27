using System.Threading.Tasks;
using Abp.Application.Services;
using HC.RetailClient.Sessions.Dto;

namespace HC.RetailClient.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
