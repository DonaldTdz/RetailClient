using System.Threading.Tasks;
using Abp.Application.Services;
using HC.RetailClient.Authorization.Accounts.Dto;

namespace HC.RetailClient.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
